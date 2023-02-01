namespace Friends_Bilgi_Yarışması
{
    public partial class FRİENDS : Form
    {
        public FRİENDS()
        {
            InitializeComponent();
        }
        
        int sorusayısı = 0, dogru = 0, yanlış = 0;
        int puan = 0, sayaç = 0;


        private void buttonBaşla_Click_1(object sender, EventArgs e)
        {

            buttonBaşla.Text = "Sonraki";
            timer1.Start();
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonBaşla.Enabled = false;
            sorusayısı++;
            label11.Text = sorusayısı.ToString();
            label12.Visible = true;
            label13.Visible = true;


            if (sorusayısı == 1)
            {
                richTextBox1.Text = "İlk soru ile başlayalım. Dizinin ilk bölümü hangi yılda yayınlanmıştır?";
                buttonA.Text = "1993";
                buttonB.Text = "1994";
                buttonC.Text = "1995";
                buttonD.Text = "1997";

                label3.Text = "1994";

            }

            if (sorusayısı == 2)
            {
                richTextBox1.Text = "Oyuncu karakter eşleştirmelerinden hangisi yanlıştır?";
                buttonA.Text = "Lisa Kudrow - Phoebe";
                buttonB.Text = "David Schwimmer - Ross";
                buttonC.Text = "Matt LeBlanc - Chandler";
                buttonD.Text = "Jennifer Aniston - Rachel";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Matt LeBlanc - Chandler";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
            }


            if (sorusayısı == 3)
            {
                richTextBox1.Text = "Chandler ve Joey’in kardeşlerinin toplam sayısı kaçtır?";
                buttonA.Text = "0";
                buttonB.Text = "7";
                buttonC.Text = "9";
                buttonD.Text = "12";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "7";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            if (sorusayısı == 4)
            {
                richTextBox1.Text = "Hangi Marvel aktörü diziye konuk olmuştur?";
                buttonA.Text = "Paul Rudd";
                buttonB.Text = "Tom Holland";
                buttonC.Text = "Paul Bettanny";
                buttonD.Text = "Sebastian Stan";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Paul Rudd";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }


            if (sorusayısı == 5)
            {
                richTextBox1.Text = "2. Sezonda Chandler, Ross’un doğum günü için herkesten kaç dolar istemiştir?";
                buttonA.Text = "40";
                buttonB.Text = "62";
                buttonC.Text = "85";
                buttonD.Text = "28";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "62";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }


            if (sorusayısı == 6)
            {
                richTextBox1.Text = "Dizinin başında Chandler’ın mesleği nedir?";
                buttonA.Text = "Bilgi Düzenleme ve Dosyalama";
                buttonB.Text = "Bilgi İşleyici";
                buttonC.Text = "Bilgi Teknolojisi Uzman Tedarik Müdürü";
                buttonD.Text = "İstatistiksel Analiz ve Yeniden Bilgi Yapılandırma";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "İstatistiksel Analiz ve Yeniden Bilgi Yapılandırma";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }


            if (sorusayısı == 7)
            {
                richTextBox1.Text = "Central Perk’da Rachel dışında başka kim çalıştı?";
                buttonA.Text = "Joey";
                buttonB.Text = "Ross";
                buttonC.Text = "Monica";
                buttonD.Text = "Chandler";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Joey";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }


            if (sorusayısı == 8)
            {
                richTextBox1.Text = "Rachel'ın en sevdiği çiçek nedir?";
                buttonA.Text = "Gül";
                buttonB.Text = "Zambak";
                buttonC.Text = "Menekşe";
                buttonD.Text = "Papatya";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Zambak";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }


            if (sorusayısı == 9)
            {
                richTextBox1.Text = "Her hafta Chandler ve Joey’in evine gelen Televizyon Rehberi kimin adına gelmektedir?";
                buttonA.Text = "Mr Chandler Bing";
                buttonB.Text = "Miss Chanandler Bong";
                buttonC.Text = "Mr Chandlerer Bang";
                buttonD.Text = "Miss Chandler Muriel Bong";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Miss Chanandler Bong";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            if (sorusayısı == 10)
            {
                richTextBox1.Text = "Rachel, Ross'a yazdığı mektup için kaç kağıt kullandı?";
                buttonA.Text = "6";
                buttonB.Text = "9";
                buttonC.Text = "18";
                buttonD.Text = "27";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "9";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }


            if (sorusayısı == 11)
            {
                richTextBox1.Text = "“Cadılar Bayramı çok aptalca. Giyinip, olmadığın biri gibi davranmak“ repliği kime aittir?";
                buttonA.Text = "Phoebe";
                buttonB.Text = "Rachel";
                buttonC.Text = "Joey";
                buttonD.Text = "Gunther";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Joey";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }


            if (sorusayısı == 12)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisini dizide evcil hayvan olarak görmedik?";
                buttonA.Text = "Kaplumbağa";
                buttonB.Text = "Ördek";
                buttonC.Text = "Fare";
                buttonD.Text = "Tüysüz Kedi";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Kaplumbağa";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }



            if (sorusayısı == 13)
            {
                richTextBox1.Text = "Friends’in son sezonu neden 18 bölüm?";
                buttonA.Text = "Konu bulamadıkları için";
                buttonB.Text = "Oyunculardan biri istemediği için";
                buttonC.Text = "Bazı bölümler yüzünden dava açıldığı için";
                buttonD.Text = "Diziye olan ilgi azaldığı için";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Oyunculardan biri istemediği için";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }



            if (sorusayısı == 14)
            {
                richTextBox1.Text = "Aşağıdaki sözlerden hangisi Smelly Cat’in sözlerinden değildir?";
                buttonA.Text = "Seni veterinere götürmezler";
                buttonB.Text = "Burnu olanlarla arkadaş değilsin";
                buttonC.Text = "Hiçbir zaman güzel kokamayacaksın";
                buttonD.Text = "Seni ne ile besliyorlar";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Hiçbir zaman güzel kokamayacaksın";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }


            if (sorusayısı == 15)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Ross'un alerjisinin olduğu yiyeceklerden biri değildir?";
                buttonA.Text = "Kivi";
                buttonB.Text = "Süt";
                buttonC.Text = "Istakoz";
                buttonD.Text = "Fıstık";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Süt";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
            }


            if (sorusayısı == 16)
            {
                richTextBox1.Text = "Joey'nin hayali çocukluk arkadaşının ismi neydi?";
                buttonA.Text = "Bernard";
                buttonB.Text = "Marcus";
                buttonC.Text = "Chloe";
                buttonD.Text = "Harry";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Bernard";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            if (sorusayısı == 17)
            {
                richTextBox1.Text = "Rachel'ın doğum günü ne zamandır?";
                buttonA.Text = "5 Ocak";
                buttonB.Text = "5 Nisan";
                buttonC.Text = "5 Mayıs";
                buttonD.Text = "5 Mart";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "5 Mayıs";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }



            if (sorusayısı == 18)
            {
                richTextBox1.Text = "'The One Where Ross Dates A Student'' bölümünde, Phoebe'nin evindeki yangın neden çıkmıştı?";
                buttonA.Text = "Phoebe 'nin saç düzleştiricisi";
                buttonB.Text = "Phoebe 'nin mumları";
                buttonC.Text = "Rachel 'ın sigarası";
                buttonD.Text = "Rachel 'ın saç düzleştiricisi";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Phoebe 'nin saç düzleştiricisi";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }


            if (sorusayısı == 19)
            {
                richTextBox1.Text = "Amerikan futbolu oynadıkları 'The One With the Football' bölümünde takımlar nasıldı?";
                buttonA.Text = "Ross,Monica,Chandler - Joey,Phoebe,Rachel";
                buttonB.Text = "Joey,Monica,Chandler - Chandler,Phoebe,Ross";
                buttonC.Text = "Ross,Joey,Rachel - Phoebe,Chandler,Monica";
                buttonD.Text = "Ross,Chandler,Rachel - Monica,Phoebe,Joey";


                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "Ross,Chandler,Rachel - Monica,Phoebe,Joey";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }


            if (sorusayısı == 20)
            {
                buttonBaşla.Text = "BİTİR";
                richTextBox1.Text = "Ross'un kaç çocuğu vardır?";
                buttonA.Text = "0";
                buttonB.Text = "1";
                buttonC.Text = "2";
                buttonD.Text = "3";
                label3.Visible = false;
                label4.Visible = false;
                label3.Text = "2";
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            if (sorusayısı == 21)
            {

                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                richTextBox1.Text = "";
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonA.Text = "";
                buttonB.Text = "";
                buttonC.Text = "";
                buttonD.Text = "";
                buttonBaşla.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Süre:   " + sayaç + "\n" + "Doğru:  " + dogru + "\n" + "Yanlış:  " + yanlış + "\n" + "Puan:  " + puan, "SONUÇ");
                buttonBaşla.Text = "";
                label3.Text = "";
                label4.Text = "";

            }

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            buttonA.Enabled = false;
            buttonB.Enabled=false;
            buttonC.Enabled=false;
            buttonD.Enabled=false;
            pictureBox1.Visible=false;
            pictureBox2.Visible=false;
        }

        private void buttonB_Click_1(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonBaşla.Enabled = true;
            label3.Visible = true;
            label4.Visible = true;
            label4.Text = buttonB.Text;


            if (label3.Text == label4.Text)
            {
                dogru++;
                puan += 5;
                label9.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlış++;
                puan -= 3;
                label10.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonBaşla.Enabled = true;
            label3.Visible = true;
            label4.Visible = true;
            label4.Text = buttonA.Text;


            if (label3.Text == label4.Text)
            {
                dogru++;
                puan += 5;
                label9.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlış++;
                puan -= 3;
                label10.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sayaç++;
            label8.Text = sayaç.ToString();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonBaşla.Enabled = true;
            label3.Visible = true;
            label4.Visible = true;
            label4.Text = buttonD.Text;


            if (label3.Text == label4.Text)
            {
                dogru++;
                puan += 5;
                label9.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlış++;
                puan -= 3;
                label10.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonBaşla.Enabled = true;
            label3.Visible = true;
            label4.Visible = true;
            label4.Text = buttonC.Text;


            if (label3.Text == label4.Text)
            {
                dogru++;
                puan += 5;
                label9.Text = dogru.ToString();
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                yanlış++;
                puan -= 3;
                label10.Text = yanlış.ToString();
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        

    }





}
