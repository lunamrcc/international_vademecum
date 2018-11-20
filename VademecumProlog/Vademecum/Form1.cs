using SbsSW.SwiPlCs;
using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vademecum
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Purple300, Primary.Purple400,
                Primary.Blue500, Accent.Purple100,
                TextShade.WHITE
            );

            InitializeComponent();
            ComboBox_Paises();
            ComboBox_Sintomas();
        }  
        
        public bool ComboBox_Paises()
        {
            paisesComboBox.DisplayMember = "Name";
            paisesComboBox.ValueMember = "Id";

            paisesComboBox.Items.Add(new Item("mexico", "mexico"));
            paisesComboBox.Items.Add(new Item("estadosUnidos", "estadosUnidos"));
            paisesComboBox.Items.Add(new Item("republicaCheca", "republicaCheca"));
            
            return true;
        }

        public bool ComboBox_Sintomas()
        {
            sintoma.DisplayMember = "Name";
            sintoma.ValueMember = "Id";
            sintoma.Items.Add(new Item("tosConFlema", "tosConFlema"));
            sintoma.Items.Add(new Item("escurrimientoNasal", "escurrimientoNasal"));
            sintoma.Items.Add(new Item("cuerpoCortado", "cuerpoCortado"));
            sintoma.Items.Add(new Item("dolorCabeza", "dolorCabeza"));
            sintoma.Items.Add(new Item("dolorGarganta", "dolorGarganta"));
            sintoma.Items.Add(new Item("tosSinFlemas", "tosSinFlemas"));
            sintoma.Items.Add(new Item("fiebre", "fiebre"));
            sintoma.Items.Add(new Item("perdidaVoz", "perdidaVoz"));
            sintoma.Items.Add(new Item("dificultadRespirar", "dificultadRespirar"));
            sintoma.Items.Add(new Item("dolorOido", "dolorOido"));
            sintoma.Items.Add(new Item("dolorCabeza", "dolorCabeza"));
            sintoma.Items.Add(new Item("dolorCabezaMovimiento", "dolorCabezaMovimiento"));
            sintoma.Items.Add(new Item("nauseasVomito", "nauseasVomito"));
            sintoma.Items.Add(new Item("dolorEstomago", "dolorEstomago"));
            sintoma.Items.Add(new Item("nauseasVomito", "nauseasVomito"));
            sintoma.Items.Add(new Item("diarrea", "diarrea"));

            sintoma2.DisplayMember = "Name";
            sintoma2.ValueMember = "Id";      
            sintoma2.Items.Add(new Item("tosConFlema", "tosConFlema"));
            sintoma2.Items.Add(new Item("escurrimientoNasal", "escurrimientoNasal"));
            sintoma2.Items.Add(new Item("cuerpoCortado", "cuerpoCortado"));
            sintoma2.Items.Add(new Item("dolorCabeza", "dolorCabeza"));
            sintoma2.Items.Add(new Item("dolorGarganta", "dolorGarganta"));
            sintoma2.Items.Add(new Item("tosSinFlemas", "tosSinFlemas"));
            sintoma2.Items.Add(new Item("fiebre", "fiebre"));
            sintoma2.Items.Add(new Item("perdidaVoz", "perdidaVoz"));
            sintoma2.Items.Add(new Item("dificultadRespirar", "dificultadRespirar"));
            sintoma2.Items.Add(new Item("dolorOido", "dolorOido"));
            sintoma2.Items.Add(new Item("dolorCabeza", "dolorCabeza"));
            sintoma2.Items.Add(new Item("dolorCabezaMovimiento", "dolorCabezaMovimiento"));
            sintoma2.Items.Add(new Item("nauseasVomito", "nauseasVomito"));
            sintoma2.Items.Add(new Item("dolorEstomago", "dolorEstomago"));
            sintoma2.Items.Add(new Item("nauseasVomito", "nauseasVomito"));
            sintoma2.Items.Add(new Item("diarrea", "diarrea"));


            sintoma3.DisplayMember = "Name";
            sintoma3.ValueMember = "Id";
            sintoma3.Items.Add(new Item("tosConFlema", "tosConFlema"));
            sintoma3.Items.Add(new Item("escurrimientoNasal", "escurrimientoNasal"));
            sintoma3.Items.Add(new Item("cuerpoCortado", "cuerpoCortado"));
            sintoma3.Items.Add(new Item("dolorCabeza", "dolorCabeza"));
            sintoma3.Items.Add(new Item("dolorGarganta", "dolorGarganta"));
            sintoma3.Items.Add(new Item("tosSinFlemas", "tosSinFlemas"));
            sintoma3.Items.Add(new Item("fiebre", "fiebre"));
            sintoma3.Items.Add(new Item("perdidaVoz", "perdidaVoz"));
            sintoma3.Items.Add(new Item("dificultadRespirar", "dificultadRespirar"));
            sintoma3.Items.Add(new Item("dolorOido", "dolorOido"));
            sintoma3.Items.Add(new Item("dolorCabeza", "dolorCabeza"));
            sintoma3.Items.Add(new Item("dolorCabezaMovimiento", "dolorCabezaMovimiento"));
            sintoma3.Items.Add(new Item("nauseasVomito", "nauseasVomito"));
            sintoma3.Items.Add(new Item("dolorEstomago", "dolorEstomago"));
            sintoma3.Items.Add(new Item("nauseasVomito", "nauseasVomito"));
            sintoma3.Items.Add(new Item("diarrea", "diarrea"));
            
            return true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public bool Prolog_Initialize()
        {
            try
            {
                Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\\Program Files (x86)\\swipl");
                Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");

                string[] p = { "-q", "-f", @"Medicamentos.pl" };
                PlEngine.Initialize(p);
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void EnterButton_Click(object sender, EventArgs e)
        {
            materialLabel5.Visible = false;

            ListBox_Medicamentos.Items.Clear();            
            PlQuery consulta;

            PlQuery cargar = new PlQuery("cargar('Medicamentos.bd')");            
            cargar.NextSolution();

            if (receta.Checked)
            {                
                if((sintoma.GetItemText(sintoma.SelectedItem) == "") || (paisesComboBox.GetItemText(paisesComboBox.SelectedItem) == ""))
                {
                    materialLabel5.Text = "Se debe de seleccionar un país y un síntoma";                    
                    materialLabel5.Visible = true;
                    ComboBox_Null();
                    return;
                }
                    consulta = new PlQuery("receta(M," + sintoma.GetItemText(sintoma.SelectedItem) + "," + paisesComboBox.GetItemText(paisesComboBox.SelectedItem) + ").");
                foreach(PlQueryVariables data in consulta.SolutionVariables)
                {
                    ListBox_Medicamentos.Items.Add(data["M"].ToString());                    
                }
            }

            else if (especialista.Checked)
            {
                if (sintoma.GetItemText(sintoma.SelectedItem) == "")
                {
                    materialLabel5.Text = "Se debe de seleccionar un síntoma";
                    materialLabel5.Visible = true;
                    ComboBox_Null();
                    return;
                }

                consulta = new PlQuery("tipoEspecialista(M," + sintoma.GetItemText(sintoma.SelectedItem) + ").");
                foreach (PlQueryVariables data in consulta.SolutionVariables)
                {
                    ListBox_Medicamentos.Items.Add(data["M"].ToString());
                }
            }

            else if (diagnosticar.Checked)
            {
                string s1 = sintoma.GetItemText(sintoma.SelectedItem);
                string s2 = sintoma2.GetItemText(sintoma2.SelectedItem);
                string s3 = sintoma3.GetItemText(sintoma3.SelectedItem);
                
                //Only one symptom - First One
                if (!(s1 == "") && (s2 == "") && (s3 == ""))
                {
                    consulta = new PlQuery("diagnosticar(" + s1 + ",Z" + ").");
                    foreach (PlQueryVariables data in consulta.SolutionVariables)
                    {
                        ListBox_Medicamentos.Items.Add(data["Z"].ToString());
                    }
                }

                //Only one symptom - Second One
                else if ((s1 == "") && !(s2 == "") && (s3 == ""))
                {
                    consulta = new PlQuery("diagnosticar(" + s2 + ",Z" + ").");
                    foreach (PlQueryVariables data in consulta.SolutionVariables)
                    {
                        ListBox_Medicamentos.Items.Add(data["Z"].ToString());
                    }
                }

                //Only one symptom - Third One
                else if ((s1 == "") && (s2 == "") && !(s3 == ""))
                {
                    consulta = new PlQuery("diagnosticar(" + s3 + ",Z" + ").");
                    foreach (PlQueryVariables data in consulta.SolutionVariables)
                    {
                        ListBox_Medicamentos.Items.Add(data["Z"].ToString());
                    }
                }

                //Two symptoms - First and Second
                else if (!(s1 == "") && (!(s2 == "")) && (s3 == ""))
                {
                    try
                    {
                        consulta = new PlQuery("diagnosticar(" + s1 + "," + s2 + ",Z" + ").");
                        foreach (PlQueryVariables data in consulta.SolutionVariables)
                        {
                            ListBox_Medicamentos.Items.Add(data["Z"].ToString());
                        }
                    }
                    catch(Exception exc)
                    {
                        string mes = exc.Message;
                        materialLabel5.Text = "No se encontraron resultados";
                        materialLabel5.Visible = true;
                        ComboBox_Null();
                    }
                }

                //Two symptoms - First and Third
                else if (!(s1 == "") && (s2 == "") && (!(s3 == "")))
                {
                    try
                    {
                        consulta = new PlQuery("diagnosticar(" + s1 + "," + s3 + ",Z" + ").");
                        foreach (PlQueryVariables data in consulta.SolutionVariables)
                        {
                            ListBox_Medicamentos.Items.Add(data["Z"].ToString());
                        }
                    }
                    catch (Exception exc)
                    {
                        string mes = exc.Message;
                        materialLabel5.Text = "No se encontraron resultados";
                        materialLabel5.Visible = true;
                        ComboBox_Null();
                    }
                }

                //Two symptoms - Second and Third
                else if ((s1 == "") && !(s2 == "") && (!(s3 == "")))
                {
                    try
                    {
                        consulta = new PlQuery("diagnosticar(" + s2 + "," + s3 + ",Z" + ").");
                        foreach (PlQueryVariables data in consulta.SolutionVariables)
                        {
                            ListBox_Medicamentos.Items.Add(data["Z"].ToString());
                        }
                    }
                    catch (Exception exc)
                    {
                        string mes = exc.Message;
                        materialLabel5.Text = "No se encontraron resultados";
                        materialLabel5.Visible = true;
                        ComboBox_Null();
                    }
                }

                //All symptoms
                else if (!(s1 == "") && (!(s2 == "")) && (!(s3 == "")))
                {
                    try
                    {
                        consulta = new PlQuery("diagnosticar(" + s1 + "," + s2 + "," + s3 + ",Z" + ").");
                        foreach (PlQueryVariables data in consulta.SolutionVariables)
                        {
                            ListBox_Medicamentos.Items.Add(data["Z"].ToString());
                        }
                    }
                    catch (Exception exc)
                    {
                        string mes = exc.Message;
                        materialLabel5.Text = "No se encontraron resultados";
                        materialLabel5.Visible = true;
                        ComboBox_Null();
                    }
                }

                //No symptoms
                else
                {
                    materialLabel5.Text = "Se debe seleccionar al menos un síntoma";
                    materialLabel5.Visible = true;
                    ComboBox_Null();
                }                

            }
            else
            {
                materialLabel5.Text = "Se debe de seleccionar una opción para buscar";
                materialLabel5.Visible = true;
            }
            ComboBox_Null();
        }

        private void especialista_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox_Null();

            materialLabel2.Visible = false;
            paisesComboBox.Visible = false;
            sintoma2.Visible = false;
            sintoma3.Visible = false;
            materialLabel3.Visible = false;
            materialLabel4.Visible = false;
        }

        private void receta_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox_Null();

            materialLabel2.Visible = true;
            paisesComboBox.Visible = true;
            sintoma2.Visible = false;
            sintoma3.Visible = false;
            materialLabel3.Visible = false;
            materialLabel4.Visible = false;
        }

        private void diagnosticar_CheckedChanged(object sender, EventArgs e)
        {
            ComboBox_Null();

            materialLabel2.Visible = false;
            paisesComboBox.Visible = false;
            sintoma2.Visible = true;
            sintoma3.Visible = true;
            materialLabel3.Visible = true;
            materialLabel4.Visible = true;
        }

        private void ComboBox_Null()
        {
            sintoma.SelectedItem = null;
            sintoma2.SelectedItem = null;
            sintoma3.SelectedItem = null;
            paisesComboBox.SelectedItem = null;
        }

        private void Initial_Click(object sender, EventArgs e)
        {
            if (!PlEngine.IsInitialized)
            {
                materialLabel5.Visible = false;

                if (Prolog_Initialize())
                {
                    materialLabel5.Text = "¡Se ha cargado el Vademecum exitósamente!";
                    materialLabel5.Visible = true;
                }
                else
                {
                    materialLabel5.Text = "Se encontró un error al inicializar Prolog, favor de leer el Reporte";
                    materialLabel5.Visible = true;
                }

            }

            Initial.Visible = false;
        }
    }
}
