using DataAccess.Entities;
using DataAccess.Operations;
using System;
using System.Collections.Generic;

namespace D2hOperator
{
    internal class GetYearlyStatement
    {
        private static string connectionString = @"Data Source=DESKTOP-HA16J39;Initial Catalog=CableSystemManagement;Integrated Security=True";

        private static YearlyStatementOperations YearlyStatement = new YearlyStatementOperations(connectionString);


        public static void Execute(string Username)
        {
            Console.WriteLine("Please Enter Year");
            string year = Console.ReadLine();
            List<YearlyStatement> yc = YearlyStatement.GetStatement(Username, year);
            foreach (YearlyStatement yr in yc)
            {
                Console.WriteLine("PaymentDate      {0}", yr.PaymentDate);
                Console.WriteLine("paidAmount       {0}", yr.paidAmount);
                Console.WriteLine("pendingAmount    {0}", yr.pendingAmount);
                Console.WriteLine("==========================================");

            }
            Console.ReadLine();
          //  LoginPage.Execute();
        }
    }
}