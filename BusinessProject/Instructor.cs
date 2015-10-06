using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject
{
    class Instructor : Person
    {
        //Feild
        private int _id;
        private string _office;

        public Instructor() { }

            //=============================  BEHAVIORS =========================
            //++++++++++++++++  DATABASE Data Elements +++++++++++++++++
            public System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter2;
            public System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
            public System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
            public System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
            public System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
            public System.Data.OleDb.OleDbConnection OleDbConnection2;
            public string cmd;

            public void DBSetup()
            {
                // +++++++++++++++++++++++++++  DBSetup function +++++++++++++++++++++++++++
                // This DBSetup() method instantiates all the DB objects needed to access a DB, 
                // including OleDbDataAdapter, which contains 4 other objects(OlsDbSelectCommand, 
                // oleDbInsertCommand, oleDbUpdateCommand, oleDbDeleteCommand.) And each
                // Command object contains a Connection object and an SQL string object.
                OleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
                OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
                OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
                OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
                OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
                OleDbConnection2 = new System.Data.OleDb.OleDbConnection();

                OleDbDataAdapter2.DeleteCommand = OleDbDeleteCommand2;
                OleDbDataAdapter2.InsertCommand = OleDbInsertCommand2;
                OleDbDataAdapter2.SelectCommand = OleDbSelectCommand2;
                OleDbDataAdapter2.UpdateCommand = OleDbUpdateCommand2;

                // The highlighted text below should be changed to the location of your own database

                OleDbConnection2.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Reg" + "istry Path =; Jet OLEDB:Database L" +
                "ocking Mode=1;Data Source= C:\\Users\\Trenton MCleod\\Desktop\\RegistrationDB.mdb;J" +
                "et OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:System datab" +
                "ase=;Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Mode=S" +
                "hare Deny None;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Create System Database=False;Jet " +
                "OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repai" +
                "r=False;User ID=Admin;Jet OLEDB:Global Bulk Transactions=1";

            }  ////end DBSetup()

            public void SelectDB(int id)
            { ///++++++++++++++++++++++++++  SELECT +++++++++++++++++++++++++

                DBSetup();
                cmd = "Select * from INSTRUCTORS where ID = " + id;
                OleDbDataAdapter2.SelectCommand.CommandText = cmd;
                OleDbDataAdapter2.SelectCommand.Connection = OleDbConnection2;
                Console.WriteLine(cmd);
                try
                {
                    OleDbConnection2.Open();
                    System.Data.OleDb.OleDbDataReader dr;
                    dr = OleDbDataAdapter2.SelectCommand.ExecuteReader();

                    dr.Read();
                    _id = id;
                    FirstName=dr.GetValue(1) + "";
                    LastName=dr.GetValue(2) + "";
               
                   

                //setRoomNo(Int32.Parse(dr.GetValue(4) + ""));
            }
            catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    OleDbConnection2.Close();
                }
            } //end SelectDB()
              //Constructor
            public Instructor(int id, string firstName, string lastName, Address address, string office, string email) : base(firstName, lastName, address, email)
        {
            _id = id;
            _office = office;
        }

        //Make ID property////
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        //Make Office Name propertyd
        public string Office
        {
            get { return _office; }
            set { _office = value; }
        }

        public void display()
        {
            Console.WriteLine("ID         =" + _id);
            //This is pulling from the Person
            base.display();
            Console.WriteLine("Office     =" + _office);
        }
    }
}

