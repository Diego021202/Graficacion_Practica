using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;

namespace Graficacion_Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            gl.ClearColor(0, 0, 0, 0);
        }

        private void openGLControl1_Resize(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(30.0f, (double)Width / (double)Height, 5, 100.0);

            gl.LookAt(-5, 5, -5, 0, 0, 0, 0, 1, 0);

            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;
            gl.LoadIdentity();
            gl.Translate(-4.8f, 0f, -6f);
            gl.Begin(OpenGL.GL_QUADS);
  

            {
                //Vértice 
                gl.Vertex(-0.5f, 4.0f, 0.0f);
                //Punto de extremo izquierdo      
                gl.Vertex(1.0f, 4.0f, 0.0f);
                //Punto final derecho       
                gl.Vertex(1.0f, -4.0f, 0.0f);
                gl.Vertex(-0.5f, -4.0f, 0.0f);
                gl.Color(1.0f, 0.0f, 0.0f);//color rojo
            }
            gl.End();

            gl.Translate(1.51F, 0f, 0.0f);
            gl.Begin(OpenGL.GL_QUADS);

            {
                //Vértice 
                gl.Vertex(-0.5f, 4.0f, 0.0f);
                //Punto de extremo izquierdo      
                gl.Vertex(1.0f, 4.0f, 0.0f);
                //Punto final derecho       
                gl.Vertex(1.0f, -4.0f, 0.0f);
                gl.Vertex(-0.5f, -4.0f, 0.0f);
                gl.Color(0.0f, 1.0f, 0.0f);//color verde

            }
            gl.End();
            gl.Translate(1.51f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);

            {
                //Vértice 
                gl.Vertex(-0.5f, 4.0f, 0.0f);
                //Punto de extremo izquierdo      
                gl.Vertex(1.0f, 4.0f, 0.0f);
                //Punto final derecho       
                gl.Vertex(1.0f, -4.0f, 0.0f);
                gl.Vertex(-0.5f, -4.0f, 0.0f);
                gl.Color(0.0f, 0.0f, 1.0f);//color azul
            }
            gl.End();
            gl.Translate(1.52f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);

            {
                //Vértice 
                gl.Vertex(-0.5f, 4.0f, 0.0f);
                //Punto de extremo izquierdo      
                gl.Vertex(1.0f, 4.0f, 0.0f);
                //Punto final derecho       
                gl.Vertex(1.0f, -4.0f, 0.0f);
                gl.Vertex(-0.5f, -4.0f, 0.0f);
                gl.Color(1.0f, 1.0f, 0.0f);//color amarillo
            }
            gl.End();

            gl.Translate(1.52f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);

            {
                //Vértice 
                gl.Vertex(-0.5f, 4.0f, 0.0f);
                //Punto de extremo izquierdo      
                gl.Vertex(1.0f, 4.0f, 0.0f);
                //Punto final derecho       
                gl.Vertex(1.0f, -4.0f, 0.0f);
                gl.Vertex(-0.5f, -4.0f, 0.0f);
                gl.Color(1.0f, 0.0f, 1.0f);//color rosa
            }
            gl.End();


            gl.Translate(1.53f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);

            {
                //Vértice 
                gl.Vertex(-0.5f, 4.0f, 0.0f);
                //Punto de extremo izquierdo      
                gl.Vertex(1.0f, 4.0f, 0.0f);
                //Punto final derecho       
                gl.Vertex(1.0f, -4.0f, 0.0f);
                gl.Vertex(-0.5f, -4.0f, 0.0f);
                gl.Color(0.0f, 1.0f, 1.0f);//color acua
            }
            gl.End();


            gl.Translate(1.54f, 0f, 0f);
            gl.Begin(OpenGL.GL_QUADS);

            {
                //Vértice 
                gl.Vertex(-0.5f, 4.0f, 0.0f);
                //Punto de extremo izquierdo      
                gl.Vertex(1.0f, 4.0f, 0.0f);
                //Punto final derecho       
                gl.Vertex(1.0f, -4.0f, 0.0f);
                gl.Vertex(-0.5f, -4.0f, 0.0f);
                gl.Color(1.0f, 1.0f, 1.0f);//color blanco
            }
            gl.End();
            gl.Flush();
        }
    }
}

