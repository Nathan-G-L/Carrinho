using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrinho
{
    public partial class Form1 : Form
    {
        #region strings
        string[,] Lista = new string[2, 5];
        string[,] Mercado = new string[4, 10];
        string[,] Carrinho = new string[3, 20];

        

        #endregion
        public Form1()
        {
            InitializeComponent();


            ListComp();
            EstoqueM();
        }

        #region Arrays
        public void ListComp()
        {

            //Itens a comprar
            Lista[0, 0] = "Pão";
            Lista[0, 1] = "Maçã";
            Lista[0, 2] = "Maionese";
            Lista[0, 3] = "Mortadela";
            Lista[0, 4] = "Farofa";

            //Quantidade de cada item
            Lista[1, 0] = "3";
            Lista[1, 1] = "5";
            Lista[1, 2] = "1";
            Lista[1, 3] = "1";
            Lista[1, 4] = "2";

            string[] Atulist = new string[Lista.GetLength(1)];

            for (int i = 0; i < Lista.GetLength(1); i++)
            {//Joga itens na lista               

                Atulist[i] = Lista[0, i];

                ckbxLista.Items.Add(Atulist[i]);
            }
            

        }

        public void EstoqueM()
        {
            //Itens mercado
            Mercado[0, 0] = "Pão";
            Mercado[0, 1] = "Maçã";
            Mercado[0, 2] = "Maionese";
            Mercado[0, 3] = "Mortadela";
            Mercado[0, 4] = "Farofa";
            Mercado[0, 5] = "Macarrão";
            Mercado[0, 6] = "Sal";
            Mercado[0, 7] = "Salgadinho";
            Mercado[0, 8] = "Coca-Cola";
            Mercado[0, 9] = "Shoyu";

            //Valor und
            Mercado[1, 0] = "1";
            Mercado[1, 1] = "1";
            Mercado[1, 2] = "1";
            Mercado[1, 3] = "1";
            Mercado[1, 4] = "1";
            Mercado[1, 5] = "1";
            Mercado[1, 6] = "1";
            Mercado[1, 7] = "1";
            Mercado[1, 8] = "1";
            Mercado[1, 9] = "1";

            //Valor Estoque
            Mercado[2, 0] = "20";
            Mercado[2, 1] = "50";
            Mercado[2, 2] = "5";
            Mercado[2, 3] = "5";
            Mercado[2, 4] = "1";
            Mercado[2, 5] = "10";
            Mercado[2, 6] = "5";
            Mercado[2, 7] = "2";
            Mercado[2, 8] = "0";
            Mercado[2, 9] = "3";

            //Peso Itens
            Mercado[3, 0] = "0.8";
            Mercado[3, 1] = "0.5";
            Mercado[3, 2] = "0.5";
            Mercado[3, 3] = "0.1";
            Mercado[3, 4] = "0.2";
            Mercado[3, 5] = "0.8";
            Mercado[3, 6] = "1.0";
            Mercado[3, 7] = "0.08";
            Mercado[3, 8] = "2.0";
            Mercado[3, 9] = "0.2";

            string[] Atulist = new string[Mercado.GetLength(1)];

            for (int i = 0; i < Mercado.GetLength(1); i++)
            {//Joga itens no mercado               

                Atulist[i] = Mercado[0, i];

                cbMerc.Items.Add(Atulist[i]);
            }

        }


        #endregion

        #region Botões
        private void btADcmp_Click(object sender, EventArgs e)
        {
            string Mercitem = cbMerc.SelectedItem.ToString();

            for(int i = 0; i < Carrinho.GetLength(1); i++)
            {
                if (Carrinho[0, i] == "" || Carrinho[0,i]==null)
                {
                    Carrinho[0, i] = Mercitem;
                    
                    ckbxCarrinho.Items.Add(Carrinho[0, i]);//Adiciona item ao carrinho

                    //Tira item do estoque
                    for (int y = 0; y < Mercado.GetLength(1); y++)
                    {
                        if (Mercado[0, y] == Mercitem)
                        {
                            int TiraEst= int.Parse(Mercado[2, y]);
                            Mercado[2, y] = (TiraEst - int.Parse(Mercado[1,y])).ToString();
                                                     

                            Carrinho[1, i] =( int.Parse(Mercado[1, y])).ToString();
                        }
                    }                   

                    break;
                }
                
            }
            //Verifica lista de compras
            for (int y = 0; y < Lista.GetLength(1);y++)
            {

                int total = 0;
                for (int i = 0; i < Carrinho.GetLength(1); i++)
                {
                    if (Lista[0, y] == Carrinho[0, i])
                    {
                        total ++;
                        if (Lista[1, y] == total.ToString())
                        {
                            ckbxLista.SetItemChecked(y, true);
                        }
                    }

                }
            }
        }
        private void btRemove_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Carrinho.GetLength(1); i++)
            {
                if (ckbxCarrinho.SelectedIndex == i)
                {
                    string Item = ckbxCarrinho.SelectedItem.ToString();
                    ckbxCarrinho.Items.RemoveAt(i);

                    Carrinho[0, i] = null;
                    Carrinho[1, i] = null;

                }
            }
        }
        private void btFim_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region Ações
        private void ckbxCarrinho_SelectedValueChanged(object sender, EventArgs e)
        {
            //Retira itens do carrinho
            for (int i = 0; i < Carrinho.GetLength(1); i++)
            {
                if (ckbxCarrinho.SelectedIndex == i)
                {
                    string Item = ckbxCarrinho.SelectedItem.ToString();
                    ckbxCarrinho.Items.RemoveAt(i);

                    Carrinho[0, i] = null;
                    Carrinho[1, i] = null;

                }
            }

            //Verifica Lista de compras
            int a = 0;
            for (int i = 0; i < Lista.GetLength(1); i++)
            {
                if (Lista[0, i] == ckbxCarrinho.SelectedItem.ToString())
                {                    
                    a++;


                }
            }

        }

        #endregion
    }
}
