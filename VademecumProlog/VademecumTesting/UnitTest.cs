using System;
using System.IO;
using Vademecum;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VademecumTesting
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test_Prolog_x86_Installed()
        {
            string prologPATH = @"C:\Program Files (x86)\swipl\bin";
            bool prologInstalled = Directory.Exists(prologPATH);

            Assert.AreEqual(true, prologInstalled);
        }

        [TestMethod]
        public void Test_Prolog_x86_Version()
        {
            string version;
            try
            {
                StreamReader sr = new StreamReader("C:\\Program Files (x86)\\swipl\\VERSION");
                version = sr.ReadLine();

                Assert.AreEqual("6.6.1", version);

            }
            catch(AssertFailedException e)
            {
                Assert.Fail();
            }            
        }

        [TestMethod]
        public void Test_Prolog_x86_DLL()
        {
            string prologPATH = "C:\\Program Files (x86)\\swipl\\bin\\libswipl.dll";
            bool prologInstalled = File.Exists(prologPATH);

            Assert.AreEqual(true, prologInstalled);
        }

        [TestMethod]
        public void Test_Vademecum_Folder()
        {
            string vademecumPATH = "C:\\VademecumProlog\\Vademecum";
            bool vademecum = Directory.Exists(vademecumPATH);

            Assert.AreEqual(true, vademecum);
        }

        [TestMethod]
        public void Test_Prolog_Medicamentos_Prolog_File()
        {
            string medicamentosPATH = "C:\\VademecumProlog\\Vademecum\\bin\\Debug\\Medicamentos.pl";            
            bool medicamentosExists = File.Exists(medicamentosPATH);

            Assert.AreEqual(true, medicamentosExists);
        }

        [TestMethod]
        public void Test_Prolog_Medicamentos_Database_File()
        {
            string medicamentosPATH = "C:\\VademecumProlog\\Vademecum\\bin\\Debug\\Medicamentos.bd";
            bool medicamentosExists = File.Exists(medicamentosPATH);

            Assert.AreEqual(true, medicamentosExists);
        }

        [TestMethod]
        public void Test_Medicamentospl_cargar()
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader("C:\\VademecumProlog\\Vademecum\\bin\\Debug\\Medicamentos.pl");
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //Check for 'cargar' rule
                    if (line == "cargar(A):-exists_file(A),consult(A).")
                    {
                        return;
                    }
                    //Read the next line
                    line = sr.ReadLine();
                }

                Assert.Fail();

            }
            catch (AssertFailedException e)
            {
                Assert.Fail();
            }            
        }

        [TestMethod]
        public void Test_Prolog_Initialize()
        {
            Form1 form = new Form1();
            bool prolog = form.Prolog_Initialize();

            Assert.AreEqual(true, prolog);
        }

        [TestMethod]
        public void Test_CountryComboBox_Not_Null()
        {
            Form1 form = new Form1();            
            Assert.AreEqual(true, form.ComboBox_Paises());
        }

        [TestMethod]
        public void Test_SyntomsComboBox_Not_Null()
        {
            Form1 form = new Form1();
            Assert.AreEqual(true, form.ComboBox_Sintomas());
        }
    }
}
