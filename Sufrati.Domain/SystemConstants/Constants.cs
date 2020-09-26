using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain
{
    public static class LookupsTypesConstants
    {
        public const long Account_TYPE = 105000000000002;
        public const long Complaint_Category = 105000000000003;
        public const long Complaint_Status = 105000000000004;
        public const long Client_Type = 105000000000005;
        public const long Import_Status = 105000000000006;
        public const long Invoice_Status = 105000000000007;
        public const long Nationality = 105000000000008;
        public const long Payment_Status = 105000000000009;
        public const long Schedule_Type = 105000000000010;
        public const long User_Type = 105000000000011;
        public const long SystemMessage_Type = 105000000000012;
        public const long Bank_Type = 105000000000013;
        public const long Economic_Sector = 105000000000014;
        public const long Compensation_Status = 105000000000015;
        public const long DataSetName = 105000000000016;
        public const long Account_Status = 157000000000000;
        public const long Currency = 102000000000000;
        public const long LogType = 105000000000019;
    }
    public static class BaseTags
    {
        public const string UserName = "User";
        public const string UserCode = "_user";
        public const string DateName = "Date";
        public const string DateCode = "_date";
        public const string ResourseName = "Resourse";
        public const string ResourseCode = "_resourse";
        public const string ActionName = "Action";
        public const string ActionCode = "_action";

    }
    public static class ResourceConstants
    {
        public const long User = 158000000000001;
        public const long Currency = 158000000000002;
        public const long Holiday = 158000000000003;
        public const long City = 158000000000004;
        public const long GeneralLookupType = 158000000000005;
        public const long SystemConstant = 158000000000007;
        public const long Bank = 158000000000008;
        public const long QuantitativeCategory = 158000000000009;
        public const long Actions = 158000000000010;
        public const long AuditLog = 158000000000011;
        public const long LookUpCodeMapping = 158000000000017;
        public const long ExchangeRate = 158000000000020;
        public const long SystemMessage = 158000000000021;
        public const long CompensationPayment = 158000000000024;
        public const long Insuree = 158000000000025;
        public const long InsureeIdentification = 158000000000027;
        public const long QuantitativeFormula = 158000000000031;
        public const long CompensationAmount = 158000000000032;
        public const long ConsolidatedDeposit = 158000000000033;
        public const long Invoice = 158000000000036;
        public const long RiskFeesRatio = 158000000000039;
        public const long RiskIndicator = 158000000000040;
        public const long Groups = 158000000000047;
        public const long PasswordPolicy = 158000000000048;
        public const long Role = 158000000000050;
        public const long QualitativeCriteria = 158000000000055;
        public const long Payments = 158000000000056;
        public const long MyNLog = 158000000000057;
        public const long PDICReserve = 158000000000058;
        public const long QuantitativeCriteriaResult = 158000000000059;
        public const long AccountStatus = 158000000000060;
    }
    public static class NotificationActionConstants
    {
        public const long Add = 168000000000001;
        public const long Update = 168000000000002;
        public const long Delete = 168000000000003;        
    }

    public static class NotificationConstants
    {
        public const char SPACE_INPUT = ' ';
        public const char FUNCTION_SYMPOL = '#';
        public const char COLUMN_NAME_START_SYMPOL = '{';
        public const char COLUMN_NAME_END_SYMPOL = '}';
        public const char VARIABLE_STRING_SYMPOL = '"';
        public const char LESS_THAN_SYMPOL = '<';
        public const char MORE_THAN_SYMPOL = '>';
        public const char AND_SYMPOL = '&';
        public const char OR_SYMPOL = '|';
        public const char NOT_SYMPOL = '!';
        public const char EQUAL_SYMPOL = '=';
        public const char COMMA_SYMPOL = ',';
        public const char OPENING_BRACE_SYMPOL = '(';
        public const char CLOSING_BRACE_SYMPOL = ')';
        public const char MULI_BRACE_SYMPOL = '*';
        public const char PLUS_BRACE_SYMPOL = '+';
        public const char MINS_BRACE_SYMPOL = '-';
        public const char DIV_BRACE_SYMPOL = '/';


    }
    public static class FunctionsNameConstants
    {
        public const string IN = "in";
        public const string IsNull = "isnull";
        public const string IsUnique = "isunique";
        public const string IsIDCardNumberValid = "isidcardnumbervalid";
        public const string Contain = "contain";
        public const string StartWith = "startwith";
        public const string IsNBANValid = "isnbanvalid";
        public const string Length = "length";
        public const string CurrentDate = "currentdate";
        public const string RowCount = "rowcount";
        public const string InList = "inlist";

    }
    public static class LookupsValuesConstants
    {
        public const long NewInvoice = 106000000000010;
        public const long NewComplaint = 106000000000014;
        public const long CancelledComplaint = 106000000000015;
        public const long ResolvedComplaint = 106000000000016;
        public const long CompensationPending = 106000000000029;        
        public const long UnpaidInvoice = 106000000000021;        
        public const long ErrorLogType = 106000000000040;        
        public const long LoginHistoryLogType = 106000000000041;        
        public const long ChangePasswordHistoryLogType = 106000000000042;        
        public const long client_Type_Individual = 106000000000011;        
        public const long USD_CURRENCY = 102000000000002;        
        public const long Compensation_Eligible = 106000000000043;        
        public const long Paid_Invoice = 106000000000022;        
    }

    public static class BankTypes
	{
		public const long Islamic = 106000000000002;
		public const long Commercial = 106000000000003;
	}
}
