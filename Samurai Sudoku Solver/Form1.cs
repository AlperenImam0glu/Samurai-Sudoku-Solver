using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamuraiSudokuSolver
{
    public partial class Form1 : Form
    {


        static int[,] sudoku1 = new int[9, 9];
        static int[,] sudoku2 = new int[9, 9];
        static int[,] sudoku3 = new int[9, 9];
        static int[,] sudoku4 = new int[9, 9];
        static int[,] sudoku5 = new int[9, 9];


        static Label label1 = new Label();
        static Label label2 = new Label();
        static Label label3 = new Label();
        static Label label4 = new Label();
        static Label label5 = new Label();
        static Label label6 = new Label();

        static Button baslatButonu = new Button();
        static Button grafikButonu = new Button();


        static List<int[]> koseSayilari = new List<int[]>();
        Form2 grafikArayuz = new Form2();
        const int butonBoyutu = 35;
        static Button[,] buttons = new Button[21, 21];


        int[,] intArray = { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },};



        public Form1()
        {



            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            string dosya = @"C:\Users\Alperen İmamoğlu\Source\Repos\Samurai Sudoku Solver\sudoku.txt";
            string[] metin = System.IO.File.ReadAllLines(dosya);

            char[] array;

            List<char[]> liste = new List<char[]>();

            for (int i = 1; i < 6; i++)
            {
                System.IO.File.WriteAllText("sonuclar" + i + ".txt", "");
            }


            for (int i = 0; i < 21; i++)
            {
                if (i < 9)
                {
                    array = metin[i].ToCharArray();
                    liste.Add(array);
                }
                if (i >= 9 && i < 12)
                {
                    array = metin[i].ToCharArray();
                    liste.Add(array);
                }
                if (i >= 12)
                {
                    array = metin[i].ToCharArray();
                    liste.Add(array);
                }
            }


            verileriDuzenle(intArray, liste);

            sudokuOlustur();

        }



        static void verileriDuzenle(int[,] intArray, List<char[]> liste)
        {

            for (int i = 0; i < liste.Count; i++)
            {

                for (int j = 0; j < liste[i].Length; j++)
                {
                    if (liste[i][j] != '*')
                    {

                        intArray[i, j] = (liste[i][j]) - '0';
                    }
                }
            }

            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {

                    Console.Write(intArray[i, j]);
                }
                Console.WriteLine();
            }


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    ///1. sudoku hesabı
                    sudoku1[i, j] = intArray[i, j];

                    /// 2. sudoku hesabı

                    if (i > 5)
                    {
                        sudoku2[i, j] = intArray[i, j + 12];
                    }
                    else
                    {
                        sudoku2[i, j] = intArray[i, j + 9];
                    }

                    /// 3. sudoku hesabı
                    if (i < 3)
                    {
                        sudoku3[i, j] = intArray[i + 6, j + 6];
                    }
                    if (i >= 3)
                    {
                        sudoku3[i, j] = intArray[i + 6, j];
                    }
                    if (i > 5)
                    {
                        sudoku3[i, j] = intArray[i + 6, j + 6];
                    }

                    /// 4. sudoku hesabı

                    sudoku4[i, j] = intArray[i + 12, j];

                    /// 5. sudoku hesabı
                    if (i < 3)
                    {
                        sudoku5[i, j] = intArray[i + 12, j + 12];
                    }
                    else
                    {
                        sudoku5[i, j] = intArray[i + 12, j + 9];
                    }
                }

            }

            koseHesapla();

        }


        static void koseHesapla()
        {
            int[] sayilar1 = new int[9];
            int[] sayilar2 = new int[9];
            int[] sayilar3 = new int[9];
            int[] sayilar4 = new int[9];
            int m = 0;

            for (int k = 0; k < 4; k++)
            {
                if (k == 0)
                {

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {

                            sayilar1[m] = sudoku1[i + 6, j + 6];
                            m++;
                        }
                    }
                }
                m = 0;
                if (k == 1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sayilar2[m] = sudoku2[i + 6, j];
                            m++;
                        }
                    }

                }
                m = 0;
                if (k == 2)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sayilar3[m] = sudoku4[i, j + 6];
                            m++;

                        }
                    }

                }
                m = 0;
                if (k == 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sayilar4[m] = sudoku5[i, j];
                            m++;
                        }
                    }

                }
                m = 0;
            }
            koseSayilari.Add(sayilar1);
            koseSayilari.Add(sayilar2);
            koseSayilari.Add(sayilar3);
            koseSayilari.Add(sayilar4);

        }


        public void sudokuOlustur()
        {
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    Button button = new Button();

                    button.Size = new Size(butonBoyutu, butonBoyutu);
                    //button.Text = map[i, j].ToString();


                    button.Location = new Point(j * butonBoyutu, i * butonBoyutu);

                    buttons[i, j] = button;

                    Font = new Font("Tahoma", 9F, FontStyle.Bold);
                    if (intArray[i, j] != 0)
                        button.Text = " ";

                    this.Controls.Add(button);
                }
            }

            baslatButonu.SetBounds(850, 20, 200, 50);
            baslatButonu.Text = "ÇÖZÜMÜ BAŞLAT";
            this.Controls.Add(baslatButonu);

            baslatButonu.Click += (s, args) =>
            {
                baslatButonu.Enabled = false;

                Thread th = new Thread(sudokuHesapla1);
                th.Start();

                Thread th2 = new Thread(sudokuHesapla2);
                th2.Start();

                Thread th3 = new Thread(sudokuHesapla3);
                th3.Start();

                Thread th4 = new Thread(sudokuHesapla4);
                th4.Start();

                Thread th5 = new Thread(sudokuHesapla5);
                th5.Start();



            };


            grafikButonu.SetBounds(875, 80, 150, 50);
            grafikButonu.Text = "Grafiği Göster";
            grafikButonu.Enabled = false;
            this.Controls.Add(grafikButonu);

            grafikButonu.Click += (s, args) =>
            {

                grafikArayuz.Visible = true;

                grafikButonu.Enabled = false;
            };



            label1.SetBounds(800, 150, 400, 100);
            label1.Text = "1. thread";
            label1.Visible = true;
            this.Controls.Add(label1);

            label2.SetBounds(800, 250, 400, 100);
            label2.Text = "2. thread";
            label2.Visible = true;
            this.Controls.Add(label2);

            label3.SetBounds(800, 350, 400, 100);
            label3.Text = "3. thread";
            label3.Visible = true;
            this.Controls.Add(label3);

            label4.SetBounds(800, 450, 400, 100);
            label4.Text = "4. thread";
            label4.Visible = true;
            this.Controls.Add(label4);

            label5.SetBounds(800, 550, 400, 70);
            label5.Text = "5. thread";
            label5.Visible = true;
            this.Controls.Add(label5);

            label6.SetBounds(750, 600, 350, 100);
            label6.Text = " ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Visible = true;
            this.Controls.Add(label6);


            sudokuEkraniDuzenle();
            sudokuSayilariYaz();
        }

        public void sudokuEkraniDuzenle()
        {
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    if (i < 6 && j > 8 || i > 14 && j > 8)
                    {
                        if (j < 12)
                        {
                            buttons[i, j].Visible = false;
                        }

                    }
                    if (i > 8 && j < 6 || i > 8 && j > 14)
                    {
                        if (i < 12)
                        {
                            buttons[i, j].Visible = false;
                        }
                    }

                }
            }

        }

        public void sudokuSayilariYaz()
        {
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    if (i < 9 && j < 9)
                    {
                        //1. sudoku
                        if (intArray[i, j] != 0)
                            buttons[i, j].Text = intArray[i, j].ToString();
                    }

                    if (i < 6 && j > 8)
                    {
                        //2. sudoku
                        if (intArray[i, j - 3] != 0)
                            buttons[i, j].Text = intArray[i, j - 3].ToString();
                    }
                    if ((i > 5 && j > 11) && (i < 9))
                    {

                        if (intArray[i, j] != 0)
                            buttons[i, j].Text = intArray[i, j].ToString();
                    }

                    //3. sudoku
                    if ((i > 5 && j > 5) && (j < 14) && (i < 9))
                    {
                        if (intArray[i, j] != 0)
                            buttons[i, j].Text = intArray[i, j].ToString();
                    }
                    if (i > 8 && i < 12 && j > 5)
                    {
                        if (intArray[i, j - 6] != 0)
                            buttons[i, j].Text = intArray[i, j - 6].ToString();
                    }

                    if ((i > 11 && j > 5) && (j < 15) && (i < 15))
                    {
                        if (intArray[i, j] != 0)
                            buttons[i, j].Text = intArray[i, j].ToString();
                    }

                    //4. sudoku
                    if ((i > 11 && j < 9))
                    {
                        if (intArray[i, j] != 0)
                            buttons[i, j].Text = intArray[i, j].ToString();
                    }

                    //5. sudoku
                    if ((i > 11 && i < 15) && j > 14)
                    {
                        if (intArray[i, j] != 0)
                            buttons[i, j].Text = intArray[i, j].ToString();
                    }
                    if ((i > 14 && j > 11))
                    {
                        if (intArray[i, j - 3] != 0)
                            buttons[i, j].Text = intArray[i, j - 3].ToString();
                    }
                }
            }

        }

        static int N = 9;

        static bool sudokuCoz(int[,] matris, List<int[,]> sonuclar, int satir,
                                int sutun, int id)
        {

            if (satir == N - 1 && sutun == N)
                return true;

            if (sutun == N)
            {
                satir++;
                sutun = 0;
            }


            if (matris[satir, sutun] != 0)
                return sudokuCoz(matris, sonuclar, satir, sutun + 1, id);

            for (int i = 1; i < 10; i++)
            {
                if (kontrolEt(matris, sonuclar, satir, sutun, i, id))
                {

                    matris[satir, sutun] = i;

                    if (sudokuCoz(matris, sonuclar, satir, sutun + 1, id))
                    {
                        String yazilacak;
                        yazilacak = ("[" + satir + "," + sutun + " = " + i + "]");
                        Console.WriteLine(yazilacak);
                        using (System.IO.StreamWriter yaz = new System.IO.StreamWriter("sonuclar" + id + ".txt", true))
                            yaz.WriteLine(yazilacak);
                        return true;
                    }

                }

                matris[satir, sutun] = 0;
            }
            return false;
        }


        static void matrisiYazdir(int[,] matris)
        {
            Console.WriteLine("==============================");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(matris[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("==============================");
        }


        static bool kontrolEt(int[,] matris, List<int[,]> sonuclar, int satir, int sutun,
                           int kontrolSayisi, int id)
        {

            for (int x = 0; x <= 8; x++)
                if (matris[satir, x] == kontrolSayisi)
                    return false;

            for (int x = 0; x <= 8; x++)
                if (matris[x, sutun] == kontrolSayisi)
                    return false;


            int startRow = satir - satir % 3, startCol
              = sutun - sutun % 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (matris[i + startRow, j + startCol] == kontrolSayisi)
                        return false;


            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (matris[i + startRow, j + startCol] == kontrolSayisi)
                        return false;


            if (id == 1)
            {
                return tekrarKontrolu(matris, sonuclar, id);

            }
            if (id == 2)
            {
                return tekrarKontrolu(matris, sonuclar, id);

            }
            if (id == 3)
            {
                return tekrarKontrolu(matris, sonuclar, id);

            }
            if (id == 4)
            {
                return tekrarKontrolu(matris, sonuclar, id);

            }
            if (id == 5)
            {
                return tekrarKontrolu(matris, sonuclar, id);

            }


            return true;
        }


        static bool tekrarKontrolu(int[,] matris, List<int[,]> sonuclar, int id)
        {
            int sayac1 = 0;
            int ayniOlanSayilar = 0;
            Boolean returnValue = true;



            if (id == 1)
            {
                for (int m = 0; m < 9; m++)
                {
                    if (koseSayilari[0][m] != 0)
                    {
                        ayniOlanSayilar++;

                    }

                }

                for (int k = 0; k < sonuclar.Count; k++)
                {
                    for (int i = 6; i < 9; i++)
                    {
                        for (int j = 6; j < 9; j++)
                        {
                            if (matris[i, j] == sonuclar[k][i, j] && (matris[i, j] != 0))
                            {
                                for (int l = 0; l < 9; l++)
                                {
                                    if (matris[i, j] != koseSayilari[0][l] && (koseSayilari[0][l] != 0))
                                    {
                                        sayac1++;
                                    }

                                }

                            }

                            if (sayac1 >= 8 - ayniOlanSayilar)
                            {
                                // Console.WriteLine("sayac =" + sayac1);

                                returnValue = false;
                            }
                        }
                        sayac1 = 0;
                    }
                    //   Console.WriteLine("sayac =" + sayac);
                    sayac1 = 0;

                }
                ayniOlanSayilar = 0;
            }


            if (id == 2)
            {
                for (int m = 0; m < 9; m++)
                {
                    if (koseSayilari[1][m] != 0)
                    {
                        ayniOlanSayilar++;

                    }

                }

                for (int k = 0; k < sonuclar.Count; k++)
                {
                    for (int i = 6; i < 9; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (matris[i, j] == sonuclar[k][i, j] && (matris[i, j] != 0))
                            {
                                for (int l = 0; l < 9; l++)
                                {
                                    if (matris[i, j] != koseSayilari[0][l] && (koseSayilari[0][l] != 0))
                                    {
                                        sayac1++;
                                    }

                                }

                            }

                            if (sayac1 >= 8 - ayniOlanSayilar)
                            {
                                // Console.WriteLine("sayac =" + sayac1);

                                returnValue = false;
                            }
                        }
                        sayac1 = 0;
                    }
                    //   Console.WriteLine("sayac =" + sayac);
                    sayac1 = 0;

                }
                ayniOlanSayilar = 0;
            }
            if (id == 3)
            {

                for (int m = 0; m < 9; m++)
                {
                    if (koseSayilari[0][m] != 0)
                    {
                        ayniOlanSayilar++;

                    }

                }

                for (int k = 0; k < sonuclar.Count; k++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (matris[i, j] == sonuclar[k][i, j] && (matris[i, j] != 0))
                            {
                                for (int l = 0; l < 9; l++)
                                {
                                    if (matris[i, j] != koseSayilari[0][l] && (koseSayilari[0][l] != 0))
                                    {
                                        sayac1++;
                                    }

                                }

                            }

                            if (sayac1 >= 8 - ayniOlanSayilar)
                            {
                                // Console.WriteLine("sayac =" + sayac1);

                                returnValue = false;
                            }
                        }
                        sayac1 = 0;
                    }
                    //   Console.WriteLine("sayac =" + sayac);
                    sayac1 = 0;

                }
                ayniOlanSayilar = 0;
            }
            if (id == 4)
            {
                for (int m = 0; m < 9; m++)
                {
                    if (koseSayilari[3][m] != 0)
                    {
                        ayniOlanSayilar++;

                    }

                }

                for (int k = 0; k < sonuclar.Count; k++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 6; j < 9; j++)
                        {
                            if (matris[i, j] == sonuclar[k][i, j] && (matris[i, j] != 0))
                            {
                                for (int l = 0; l < 9; l++)
                                {
                                    if (matris[i, j] != koseSayilari[0][l] && (koseSayilari[0][l] != 0))
                                    {
                                        sayac1++;
                                    }
                                }
                            }

                            if (sayac1 >= 8 - ayniOlanSayilar)
                            {
                                // Console.WriteLine("sayac =" + sayac1);

                                returnValue = false;
                            }
                        }
                        sayac1 = 0;
                    }
                    //   Console.WriteLine("sayac =" + sayac);
                    sayac1 = 0;

                }
                ayniOlanSayilar = 0;
            }

            if (id == 5)
            {
                for (int m = 0; m < 9; m++)
                {
                    if (koseSayilari[3][m] != 0)
                    {
                        ayniOlanSayilar++;

                    }

                }

                for (int k = 0; k < sonuclar.Count; k++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (matris[i, j] == sonuclar[k][i, j] && (matris[i, j] != 0))
                            {
                                for (int l = 0; l < 9; l++)
                                {
                                    if (matris[i, j] != koseSayilari[0][l] && (koseSayilari[0][l] != 0))
                                    {
                                        sayac1++;
                                    }
                                }
                            }
                            if (sayac1 >= 8 - ayniOlanSayilar)
                            {
                                // Console.WriteLine("sayac =" + sayac1);

                                returnValue = false;
                            }
                        }
                        sayac1 = 0;
                    }
                    //   Console.WriteLine("sayac =" + sayac);
                    sayac1 = 0;

                }
                ayniOlanSayilar = 0;
            }

            return returnValue;

        }

        static bool hesapla(int[,] grid, List<int[,]> sonuclar, int id)
        {

            if (sudokuCoz(grid, sonuclar, 0, 0, id))
                return true;
            else
                return false;

        }

        static void sonuclariYazdir(List<int[,]> sonuclar)
        {
            for (int k = 0; k < sonuclar.Count; k++)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine(k + 1 + ". çözüm");
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(sonuclar[k][i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------");
            }
        }

        static void diziyiSifirla(int[,] matris, int[,] baslangicMatris)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matris[i, j] = baslangicMatris[i, j];
                }
            }
        }

        static void sudokuHesapla1()
        {
            hesapla(sudoku1, 1);
        }

        static void sudokuHesapla2()
        {
            hesapla(sudoku2, 2);
        }
        static void sudokuHesapla3()
        {
            hesapla(sudoku3, 3);
        }
        static void sudokuHesapla4()
        {
            hesapla(sudoku4, 4);
        }
        static void sudokuHesapla5()
        {
            hesapla(sudoku5, 5);
        }

        static Boolean thread1 = false;
        static Boolean thread2 = false;
        static Boolean thread3 = false;
        static Boolean thread4 = false;
        static Boolean thread5 = false;


        static List<TimeSpan> gecenSure = new List<TimeSpan>();
        static List<int> bulunanKareler = new List<int>();

        static void hesapla(int[,] sudoku1, int id)
        {
            int[,] baslangicMatris = new int[9, 9];


            int[,] matris = new int[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matris[i, j] = sudoku1[i, j];
                    baslangicMatris[i, j] = sudoku1[i, j];
                }
            }


            List<int[,]> sonuclar = new List<int[,]>();
            matrisiYazdir(matris);


            Boolean devam = true;
            int sayac = 0;

            DateTime start = DateTime.Now;
            //Console.WriteLine(start.ToString("h:mm:ss"));


            while (devam)
            {
                int[,] kontrolDizisi = new int[9, 9];
                devam = hesapla(matris, sonuclar, id);
                using (System.IO.StreamWriter yaz = new System.IO.StreamWriter("sonuclar" + id + ".txt", true))
                    yaz.WriteLine("===========");

                if (!devam)
                    break;

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        kontrolDizisi[i, j] = matris[i, j];
                    }
                }


                sayac++;
                if (id == 1)
                {
                    Console.WriteLine("1. thread bulunan cözüm = " + sayac);
                    label1.Text = "1. thread bulunan cozum " + sayac;
                }
                if (id == 2)
                {
                    Console.WriteLine("2. thread bulunan cözüm = " + sayac);
                    label2.Text = "2. thread bulunan cozum " + sayac;
                }
                if (id == 3)
                {
                    Console.WriteLine("3. thread bulunan cözüm = " + sayac);
                    label3.Text = "3. thread bulunan cozum " + sayac;
                }
                if (id == 4)
                {
                    Console.WriteLine("4. thread bulunan cözüm = " + sayac);
                    label4.Text = "4. thread bulunan cozum " + sayac;
                }
                if (id == 5)
                {
                    Console.WriteLine("5. thread bulunan cözüm = " + sayac);
                    label5.Text = "5. thread bulunan cozum " + sayac;
                }
                sonuclar.Add(kontrolDizisi);

                diziyiSifirla(matris, baslangicMatris);
            }


            DateTime finish = DateTime.Now;
            //Console.WriteLine(finish.ToString("h:mm:ss"));

            sonuclariYazdir(sonuclar);
            var diff = finish.Subtract(start);

            Console.WriteLine("==============================================");
            Console.WriteLine("1. threadin bulduğu çözüm sayısı = " + sayac);
            Console.WriteLine("\nhesaplama için gecen süre = " + diff.ToString());
            Console.WriteLine("==============================================");

            if (id == 1)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        sudoku1[i, j] = sonuclar[0][i, j];
                    }
                }
                label1.Text = "1 .thread islemlerini " + sayac + " sonuc ile tamamladi. \nSüre: " + diff.ToString();
                Form2.gecenSure.Add(diff);
                Form2.bulunanKareler.Add(sayac);
                Form2.siralama.Add(id-1);
                thread1 = true;
            }

            if (id == 2)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        sudoku2[i, j] = sonuclar[0][i, j];
                    }
                }
                label2.Text = "2 .thread islemlerini " + sayac + " sonuc ile tamamladi. \nSüre: " + diff.ToString();
                Form2.gecenSure.Add(diff);
                Form2.bulunanKareler.Add(sayac);
                Form2.siralama.Add(id-1);
                thread2 = true;
            }
            if (id == 3)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        sudoku3[i, j] = sonuclar[0][i, j];
                    }
                }
                label3.Text = "3 .thread islemlerini " + sayac + " sonuc ile tamamladi. \nSüre: " + diff.ToString();
                Form2.gecenSure.Add(diff);
                Form2.bulunanKareler.Add(sayac);
                Form2.siralama.Add(id-1);
                thread3 = true;
            }
            if (id == 4)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        sudoku4[i, j] = sonuclar[0][i, j];
                    }
                }
                label4.Text = "4 .thread islemlerini " + sayac + " sonuc ile tamamladi. \nSüre: " + diff.ToString();
                Form2.gecenSure.Add(diff);
                Form2.bulunanKareler.Add(sayac);
                Form2.siralama.Add(id-1);
                thread4 = true;
            }
            if (id == 5)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        sudoku5[i, j] = sonuclar[0][i, j];
                    }
                }
                label5.Text = "5 .thread islemlerini " + sayac + " sonuc ile tamamladi. \nSüre: " + diff.ToString();
                Form2.gecenSure.Add(diff);
                Form2.bulunanKareler.Add(sayac);
                Form2.siralama.Add(id-1);
                thread5 = true;
            }
            threadKontrol();
        }

        static void threadKontrol()
        {

            if (thread1 == true && thread2 == true && thread3 == true && thread4 == true && thread5 == true)
            {
                label6.Text = "TÜM THREADLAR İŞLEMLERİ BİTİRDİ";
                sonuclariYazdir();
                grafikButonu.Enabled = true;
            }
        }


        static void sonuclariYazdir()
        {


            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {

                    if (i < 9 && j < 9)
                    {
                        buttons[i, j].Text = sudoku1[i, j] + "";
                    }
                    if (i < 9 && j > 11)
                    {
                        buttons[i, j].Text = sudoku2[i, j - 12] + "";
                    }

                    if (i > 11 && j < 9)
                    {
                        buttons[i, j].Text = sudoku4[i - 12, j] + "";
                    }
                    if (i > 11 && j > 11)
                    {
                        buttons[i, j].Text = sudoku5[i - 12, j - 12] + "";
                    }
                    if (i > 5 && i < 15)
                    {
                        if (j > 5 && j < 15)
                            buttons[i, j].Text = sudoku3[i - 6, j - 6] + "";
                    }
                }

            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
