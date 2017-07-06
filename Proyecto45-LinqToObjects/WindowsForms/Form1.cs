using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] books = { "Historia de Filadelfia", "El Padrino", "Sexo en Nueva York", "Tarzan de los Monos" };

            var query = from book in books
                        where book.Length > 10
                        orderby book
                        select new
                        {
                            BOOK = book.ToUpper()
                        };
            
            //dataGridView1.DataSource = books.ToList();
            /* nel form no hacefalta el DataBind() */

            List<Books> books1 = Books.GetBooks();

            var booksTitles = from b in books1
                              select new
                              {
                                  Libros = b.Title,
                                  Precio = b.Price
                              };

            dataGridView1.DataSource = booksTitles.ToList();
        }
    }
}
