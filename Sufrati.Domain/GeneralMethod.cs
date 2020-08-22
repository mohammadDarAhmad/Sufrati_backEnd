using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Security.Claims;
using System.Security.Cryptography;
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
                baseData.LastModifiedByID = userId;
                baseData.Created_Date = DateTime.Now;
            }
            //This is update operation
            else
            {
                if (userId != -1)
                {
                    baseData.LastModifiedByID = userId;
                }
            }



            return data;
        }
        public static int GetUserID(ClaimsPrincipal User)
        {
            try
            {
                return int.Parse(User.FindFirst("id")?.Value);
            }
            catch (Exception ex)
            {

                return -1;
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

        //Password Hashing
        public static string PasswordEncryption(string password)
        {
            // generate a 128-bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
    }
}


