using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
namespace Sufrati.Domain
{
    public static class GeneralMethod
    {
       
            public static T AddBaseProperties<T>(T data, IHttpContextAccessor accessor, ClaimsPrincipal user, bool isAdd)
            {
                var baseData = data as BaseEntity;
                baseData.IPAddress = accessor.HttpContext.Connection.RemoteIpAddress.ToString();
                baseData.LastModifiedDate = DateTime.Now;
                var userId = GetUserID(user);
                if (isAdd)
                {
                    if (userId != -1)
                    {
                        baseData.CreatedByID = userId;
                    }
                    baseData.CreatedByID = userId;
                    baseData.LastModifiedByID = userId;
                    baseData.CreatedDate = DateTime.Now;
                    baseData.LastModifiedDate = DateTime.Now;
                }
                //This is update operation
                else
                {
                    if (userId != -1)
                    {
                        baseData.LastModifiedByID = userId;
                        baseData.LastModifiedDate = DateTime.Now;
                    }
                    baseData.LastModifiedByID = userId;
                    baseData.LastModifiedDate = DateTime.Now;
                }
                return data;
            }

            public static string GetUserName(ClaimsPrincipal User)
            {
                try
                {
                    return User.FindFirst("fullName")?.Value;
                }
                catch (Exception)
                {
                    return "ahmad";
                }
            }
            public static long GetUserID(ClaimsPrincipal User)
            {
                try
                {
                    return long.Parse(User.FindFirst("id")?.Value);
                }
                catch (Exception)
                {
                    return -1;
                }
            }

            public static void CheckPassword(string password, long passwordPolicyID, IPasswordPolicyRepository passwordPolicyRepository)
            {

                var result = passwordPolicyRepository.GetPasswordPolicyById(passwordPolicyID);
                var chick = result.Result;
                string pattern = "";
                if (string.IsNullOrEmpty(password))
                {
                    throw new Exception();
                }
                if (password.Length < chick.MinLength)
                {
                    throw new Exception();
                }
                if (chick.IncludeCharacter)
                {
                    pattern = "[a-zA-Z]";
                    if (!Regex.IsMatch(password, pattern))
                        throw new Exception();
                }
                if (chick.IncludeNumeric)
                {
                    pattern = "[0-9]";
                    if (!Regex.IsMatch(password, pattern))
                        throw new Exception();
                }
                if (chick.IncludeSpecialCharacter)
                {

                    pattern = "[^a-zA-Z0-9]";
                    if (!Regex.IsMatch(password, pattern))
                        throw new Exception();
                }


            }


            public static int DetectPeriodQuarter(DateTime date, CancellationToken ct = default(CancellationToken))
            {
                if (date.Month >= 4 && date.Month <= 6)
                    return 2;
                else if (date.Month >= 7 && date.Month <= 9)
                    return 3;
                else if (date.Month >= 10 && date.Month <= 12)
                    return 4;
                else
                    return 1;
            }

            //public async static Task<MemoryStream> ExportToExcel(string ConnString, string TableName, CancellationToken ct = default(CancellationToken))
            //{
            //    var query = "SELECT * FROM " + TableName + "";
            //    List<string> columns = new List<string>();
            //    DataTable tbl = new DataTable();

            //    IDbConnection Connection = new SqlConnection(ConnString);
            //    using (IDbConnection cn = Connection)
            //    {
            //        cn.Open();
            //        var rdr = await cn.ExecuteReaderAsync(query);
            //        for (int i = 0; i < rdr.FieldCount; i++)
            //            columns.Add(rdr.GetName(i));
            //        tbl.Load(rdr);
            //    }

            //    ExcelPackage Excel = new ExcelPackage();
            //    Excel.Workbook.Worksheets.Add(TableName); string headerRange = "A1:" + Char.ConvertFromUtf32(columns[0].ToString().Length + 64) + "1";
            //    var worksheet = Excel.Workbook.Worksheets[TableName];
            //    worksheet.Cells[headerRange].LoadFromDataTable(tbl, true);

            //    var stream = new MemoryStream(Excel.GetAsByteArray());
            //    stream.Position = 0;


            //    return stream;
            //}

            //public async static Task<byte[]> ExportToPDF(string ConnString, string query, CancellationToken ct = default(CancellationToken))
            //{
            //    List<string> columns = new List<string>();
            //    DataTable tbl = new DataTable();

            //    IDbConnection Connection = new SqlConnection(ConnString);
            //    using (IDbConnection cn = Connection)
            //    {
            //        cn.Open();
            //        var rdr = await cn.ExecuteReaderAsync(query);
            //        for (int i = 0; i < rdr.FieldCount; i++)
            //            columns.Add(rdr.GetName(i));
            //        tbl.Load(rdr);
            //    }

            //    byte[] content;

            //    using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            //    {

            //        Document document = new Document(PageSize.A4.Rotate());

            //        PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);

            //        document.Open();

            //        PdfPTable table = new PdfPTable(tbl.Columns.Count);
            //        table.WidthPercentage = 100;

            //        string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

            //        //Create a base font object making sure to specify IDENTITY-H
            //        BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            //        //Create a specific font object
            //        iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

            //        //Set columns names in the pdf file
            //        for (int k = 0; k < tbl.Columns.Count; k++)
            //        {
            //            PdfPCell cell = new PdfPCell(new Phrase(tbl.Columns[k].ColumnName, f));

            //            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //            cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
            //            cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);
            //            cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            //            table.AddCell(cell);
            //        }

            //        //Add values of DataTable in pdf file
            //        for (int i = 0; i < tbl.Rows.Count; i++)
            //        {
            //            for (int j = 0; j < tbl.Columns.Count; j++)
            //            {
            //                PdfPCell cell = new PdfPCell(new Phrase(tbl.Rows[i][j].ToString(), f));

            //                //Align the cell in the center
            //                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
            //                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            //                table.AddCell(cell);
            //            }
            //        }

            //        document.Add(table);
            //        document.Close();

            //        // Create the file
            //        content = memoryStream.ToArray();
            //        return content;

            //    }

            //}

            //public async static Task<byte[]> ExportToPDFWithTowQueries(string ConnString, string query, string query2, CancellationToken ct = default(CancellationToken))
            //{
            //    List<string> columns = new List<string>();
            //    DataTable tbl = new DataTable();
            //    DataTable tb2 = new DataTable();

            //    IDbConnection Connection = new SqlConnection(ConnString);
            //    using (IDbConnection cn = Connection)
            //    {
            //        cn.Open();
            //        var rdr = await cn.ExecuteReaderAsync(query);
            //        for (int i = 0; i < rdr.FieldCount; i++)
            //            columns.Add(rdr.GetName(i));
            //        tbl.Load(rdr);

            //        var rdr2 = await cn.ExecuteReaderAsync(query2);
            //        for (int i = 0; i < rdr2.FieldCount; i++)
            //            columns.Add(rdr2.GetName(i));
            //        tb2.Load(rdr2);
            //    }

            //    byte[] content;

            //    using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            //    {

            //        Document document = new Document(PageSize.A4.Rotate());

            //        PdfWriter writer = PdfWriter.GetInstance(document, memoryStream);

            //        document.Open();

            //        PdfPTable table = new PdfPTable(tbl.Columns.Count);
            //        table.WidthPercentage = 100;

            //        PdfPTable table2 = new PdfPTable(tb2.Columns.Count);
            //        table2.WidthPercentage = 100;

            //        string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

            //        //Create a base font object making sure to specify IDENTITY-H
            //        BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            //        //Create a specific font object
            //        iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

            //        //Set columns names in the pdf file
            //        for (int k = 0; k < tbl.Columns.Count; k++)
            //        {
            //            PdfPCell cell = new PdfPCell(new Phrase(tbl.Columns[k].ColumnName, f));

            //            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //            cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
            //            cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);
            //            cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            //            table.AddCell(cell);
            //        }

            //        //Add values of DataTable in pdf file
            //        for (int i = 0; i < tbl.Rows.Count; i++)
            //        {
            //            for (int j = 0; j < tbl.Columns.Count; j++)
            //            {
            //                PdfPCell cell = new PdfPCell(new Phrase(tbl.Rows[i][j].ToString(), f));

            //                //Align the cell in the center
            //                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
            //                cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            //                table.AddCell(cell);
            //            }
            //            //Set columns names in the pdf file
            //            for (int k = 0; k < tb2.Columns.Count; k++)
            //            {
            //                PdfPCell cell1 = new PdfPCell(new Phrase(tb2.Columns[k].ColumnName, f));

            //                cell1.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //                cell1.VerticalAlignment = PdfPCell.ALIGN_CENTER;
            //                cell1.BackgroundColor = new iTextSharp.text.BaseColor(210, 210, 210);
            //                cell1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            //                table2.AddCell(cell1);
            //            }

            //            //Add values of DataTable in pdf file
            //            for (int h = 0; h < tb2.Rows.Count; h++)
            //            {
            //                for (int g = 0; g < tb2.Columns.Count; g++)
            //                {
            //                    PdfPCell cell2 = new PdfPCell(new Phrase(tb2.Rows[h][g].ToString(), f));

            //                    //Align the cell in the center
            //                    cell2.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //                    cell2.VerticalAlignment = PdfPCell.ALIGN_CENTER;
            //                    cell2.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            //                    table2.AddCell(cell2);
            //                }
            //            }
            //        }
            //        ;
            //        table.SpacingBefore = 10f;
            //        table.SpacingAfter = 12.5f;
            //        table2.SpacingBefore = 20f;
            //        table2.SpacingAfter = 12.5f;
            //        document.Add(table);
            //        document.Add(table2);
            //        document.Close();

            //        // Create the file
            //        content = memoryStream.ToArray();
            //        return content;

            //    }

            //}

            //public async static Task<List<PdfPTable>> ExporObjectToPDF(string ConnString, string query, string query2, CancellationToken ct = default(CancellationToken))
            //{
            //    List<string> columns = new List<string>();
            //    List<PdfPTable> tables = new List<PdfPTable>();
            //    DataTable tbl = new DataTable();
            //    DataTable tb2 = new DataTable();

            //    IDbConnection Connection = new SqlConnection(ConnString);
            //    using (IDbConnection cn = Connection)
            //    {
            //        cn.Open();
            //        var rdr = await cn.ExecuteReaderAsync(query);
            //        for (int i = 0; i < rdr.FieldCount; i++)
            //            columns.Add(rdr.GetName(i));
            //        tbl.Load(rdr);

            //        var rdr2 = await cn.ExecuteReaderAsync(query2);
            //        for (int i = 0; i < rdr2.FieldCount; i++)
            //            columns.Add(rdr2.GetName(i));
            //        tb2.Load(rdr2);
            //    }

            //    PdfPTable table = new PdfPTable(tbl.Columns.Count);
            //    table.WidthPercentage = 100;

            //    PdfPTable table2 = new PdfPTable(tb2.Columns.Count);
            //    table2.WidthPercentage = 100;

            //    string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");

            //    Create a base font object making sure to specify IDENTITY-H
            //    BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            //    Create a specific font object
            //    iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

            //    Set columns names in the pdf file
            //    for (int k = 0; k < tbl.Columns.Count; k++)
            //    {
            //        PdfPCell cell = new PdfPCell(new Phrase(tbl.Columns[k].ColumnName, f));

            //        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //        cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
            //        cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);
            //        cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            //        table.AddCell(cell);
            //    }

            //    Add values of DataTable in pdf file
            //    for (int i = 0; i < tbl.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < tbl.Columns.Count; j++)
            //        {
            //            PdfPCell cell = new PdfPCell(new Phrase(tbl.Rows[i][j].ToString(), f));

            //            Align the cell in the center
            //            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //            cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
            //            cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            //            table.AddCell(cell);
            //        }
            //        Set columns names in the pdf file
            //        for (int k = 0; k < tb2.Columns.Count; k++)
            //        {
            //            PdfPCell cell1 = new PdfPCell(new Phrase(tb2.Columns[k].ColumnName, f));

            //            cell1.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //            cell1.VerticalAlignment = PdfPCell.ALIGN_CENTER;
            //            cell1.BackgroundColor = new iTextSharp.text.BaseColor(210, 210, 210);
            //            cell1.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            //            table2.AddCell(cell1);
            //        }

            //        Add values of DataTable in pdf file
            //        for (int h = 0; h < tb2.Rows.Count; h++)
            //        {
            //            for (int g = 0; g < tb2.Columns.Count; g++)
            //            {
            //                PdfPCell cell2 = new PdfPCell(new Phrase(tb2.Rows[h][g].ToString(), f));

            //                Align the cell in the center
            //                cell2.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            //                cell2.VerticalAlignment = PdfPCell.ALIGN_CENTER;
            //                cell2.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            //                table2.AddCell(cell2);
            //            }
            //        }
            //    };
            //    tables.Add(table);
            //    tables.Add(table2);
            //    return tables;
            //}


            //Password Hashing
            public static string PasswordEncryption(string password, string Salt)
            {
                // generate a 128-bit salt using a secure PRNG
                byte[] salt = new byte[128 / 8];
                if (String.IsNullOrEmpty(Salt))
                {
                    using (var rng = RandomNumberGenerator.Create())
                    {
                        rng.GetBytes(salt);
                    }
                    Salt = Convert.ToBase64String(salt);
                }
                else
                {
                    salt = Convert.FromBase64String(Salt);
                }

                // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));
                hashed = Salt + ":::" + hashed;
                return hashed;
            }


        }
    }
