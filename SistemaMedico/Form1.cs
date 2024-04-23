using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaMedico
{
    public partial class Form1 : Form
    {
        private Nodo currentNode;
        private string nombreUsuario;
        public Form1(string nombre)
        {
            InitializeComponent();
            currentNode = ConstruirArbol();
            UpdateForm();
            this.nombreUsuario = nombre; // Almacena el nombre del usuario
        }

        private Nodo ConstruirArbol()
        {
            Nodo raiz = new Nodo("¿Tiene congestión nasal?");

            // Rama Sí: Congestión Nasal
            Nodo congestionNasalSi = new Nodo("¿Estornuda con frecuencia?");
            raiz.NodoSi = congestionNasalSi;

            // Diferencia entre Resfriado, Sinusitis, Alergia y Gripe
            congestionNasalSi.NodoSi = new Nodo("¿Tiene picazón en los ojos?")
            {
                NodoSi = new Nodo("¿Presenta erupciones cutáneas?")
                {
                    NodoSi = new Nodo("¿Experimenta sibilancias?") // Alergia
                    {
                        Diagnostico = "Alergia",
                        Tratamiento = "Antihistamínicos, descongestionantes, evitación del alérgeno."
                    }
                } 
            };

            congestionNasalSi.NodoNo = new Nodo("¿Presenta fiebre?") //
            {
                NodoSi = new Nodo("¿Presenta dolor de cabeza?")
                {
                    NodoSi = new Nodo("¿Presenta fatiga?")
                    {
                        NodoSi = new Nodo("¿Presenta dolor de garganta?")
                        {
                            Diagnostico = "Gripe",
                            Tratamiento = "descanso, líquidos, medicamentos para reducir la fiebre y aliviar los síntomas."
                        }
                    }
                },
                NodoNo = new Nodo("¿Le duele la garganta?")
                {
                    NodoSi = new Nodo("¿Tiene tos?")
                    {
                        NodoSi = new Nodo("¿Siente un leve malestar general?") // Resfriado común
                        {
                            Diagnostico = "Resfriado común",
                            Tratamiento = "Descanso, líquidos, medicamentos para aliviar la congestión y la tos."
                        }
                    },
                    NodoNo = new Nodo("¿Experimenta dolor facial?") // Sinusitis
                    {
                        NodoSi = new Nodo("¿Siente presión en los senos paranasales?")
                        {
                            NodoSi = new Nodo("¿Presenta secreción nasal espesa y verde?")
                            {
                                Diagnostico = "Sinusitis",
                                Tratamiento = "Analgésicos, descongestionantes, irrigación nasal, humidificadores."
                            }
                        }
                    }
                }
            };


            // Rama No: Sin Congestión Nasal
            Nodo congestionNasalNo = new Nodo("¿Tiene tos persistente?");
            raiz.NodoNo = congestionNasalNo;

            
            congestionNasalNo.NodoSi = new Nodo("¿Presenta producción de esputo?")
            {
                NodoSi = new Nodo("¿Experimenta dificultad para respirar?")
                {
                    NodoSi = new Nodo("¿Siente fatiga?")
                    {
                        NodoSi = new Nodo("¿Le duele el pecho?") // Bronquitis
                        {
                            Diagnostico = "Bronquitis",
                            Tratamiento = "Descanso, líquidos, inhaladores broncodilatadores, medicamentos para aliviar la tos."
                        }
                    }
                }
            };

            return raiz;
        }

        private void btnSi_Click(object sender, EventArgs e) //Se crea evento del botón para que realice la accion indicada a la hora de darle click 
        {
            if (currentNode.NodoSi != null)
            {
                currentNode = currentNode.NodoSi;
                UpdateForm();
            }
        }

        private void btnNo_Click(object sender, EventArgs e) //Se crea evento del botón para que realice la accion indicada a la hora de darle click 
        {
            if (currentNode.NodoNo != null)
            {
                currentNode = currentNode.NodoNo;
                UpdateForm();
            }
        }

        private void UpdateForm() //metodo para actualizar y mostrar la posible enfermedad/diagnostico y su tratamiento
        {
            if (!string.IsNullOrEmpty(currentNode.Diagnostico))
            {
                richTxtBxDiagnostico.Text = $"{nombreUsuario}, su diagnóstico es: {currentNode.Diagnostico}";
                richTxtBxTratamiento.Text =$"Tratamiento : {currentNode.Tratamiento}";
            }
            else
            {
                labelPregunta.Text = currentNode.Pregunta;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarDiagnostico();
        }

        private void ReiniciarDiagnostico()
        {
            currentNode = ConstruirArbol(); // Reinicia el árbol al nodo raíz
            UpdateForm(); // Actualiza el formulario para mostrar la primera pregunta

            // Limpia los cuadros de texto 
            richTxtBxDiagnostico.Text = "";
            richTxtBxTratamiento.Text = "";
        }


   












    }//cierre
}//cierre
