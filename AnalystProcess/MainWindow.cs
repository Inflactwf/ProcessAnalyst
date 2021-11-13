using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AnalystProcess
{
    public partial class MainWindow : Form
    {
        string CurrentDrive = @"C:\";
        bool InternalError = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StartBtn.Enabled = false;
                string Firstname = "xampp-control";
                string Secondname = "httpd";
                Process[] FirstProc = Process.GetProcessesByName(Firstname);
                Process[] SecondProc = Process.GetProcessesByName(Secondname);
                foreach (Process anti in FirstProc)
                {
                    string FileLocation = Path.GetDirectoryName(anti.MainModule.FileName);

                    if (FirstProc.Length != 0)
                    {
                        if (LogBox.Text.Length == 0)
                        {
                            LogBox.Text += "[" + DateTime.Now + "] " + Environment.NewLine + "Найден процесс: " + anti.ProcessName + " (" + FirstProc.Length + ")" + Environment.NewLine + "ID процесса: " + anti.Id + Environment.NewLine + "Время запуска процесса: " + anti.StartTime + Environment.NewLine + "Рабочая папка: " + FileLocation;
                        }
                        else
                        {
                            LogBox.Text += Environment.NewLine + Environment.NewLine + "[" + DateTime.Now + "] " + Environment.NewLine + "Найден процесс: " + anti.ProcessName + " (" + FirstProc.Length + ")" + Environment.NewLine + "ID процесса: " + anti.Id + Environment.NewLine + "Время запуска процесса: " + anti.StartTime + Environment.NewLine + "Рабочая папка: " + FileLocation;
                        }

                        if (File.Exists(FileLocation + @"\htdocs\lib\HTMLParser.php"))
                        {
                            FileInfo fi = new FileInfo(FileLocation + @"\htdocs\lib\HTMLParser.php");
                            if (fi.Length == 55265)
                            {
                                LogBox.Text += Environment.NewLine + "Найден HTMLParser последней версии. [55265 bytes] (" + FileLocation + @"\htdocs" + ")";
                                LogBox.Text += Environment.NewLine + "Дата создания: " + fi.CreationTime;
                                LogBox.Text += Environment.NewLine + "Дата последнего открытия: " + fi.LastAccessTime;
                                LogBox.Text += Environment.NewLine + "Дата последнего редактирования: " + fi.LastWriteTime;
                                //Directory.Delete(FileLocation + @"\htdocs", true);
                                LogBox.Text += Environment.NewLine + "Удаление HTMLParser завершено.";
                                break;
                            }
                            else
                            {
                                LogBox.Text += Environment.NewLine + "Найдена одна из старых версий HTMLParser. (" + FileLocation + @"\htdocs" + ")";
                                LogBox.Text += Environment.NewLine + "Дата создания: " + fi.CreationTime;
                                LogBox.Text += Environment.NewLine + "Дата последнего открытия: " + fi.LastAccessTime;
                                LogBox.Text += Environment.NewLine + "Дата последнего редактирования: " + fi.LastWriteTime;
                            }
                        }
                    }
                }

                if (FirstProc.Length == 0)
                {
                    if (LogBox.Text.Length == 0)
                    {
                        LogBox.Text += "[" + DateTime.Now + "] " + Environment.NewLine + "Процессов с названием '" + Firstname + "' не найдено, проверяем Apache.";
                    }
                    else
                    {
                        LogBox.Text += Environment.NewLine + Environment.NewLine + "[" + DateTime.Now + "] " + Environment.NewLine + "Процессов с названием '" + Firstname + "' не найдено, проверяем Apache.";
                    }

                    foreach (Process secondanti in SecondProc)
                    {
                        string FileLocation = Path.GetDirectoryName(secondanti.MainModule.FileName);
                        string FormatPath = Directory.GetParent(Directory.GetParent(FileLocation).ToString()).ToString();

                        if (SecondProc.Length != 0)
                        {
                            if (LogBox.Text.Length == 0)
                            {
                                LogBox.Text += "[" + DateTime.Now + "] " + Environment.NewLine + "Найден процесс: " + secondanti.ProcessName + " (" + SecondProc.Length + ")" + Environment.NewLine + "ID процесса: " + secondanti.Id + Environment.NewLine + "Время запуска процесса: " + secondanti.StartTime + Environment.NewLine + "Рабочая папка: " + FileLocation;
                            }
                            else
                            {
                                LogBox.Text += Environment.NewLine + Environment.NewLine + "[" + DateTime.Now + "] " + Environment.NewLine + "Найден процесс: " + secondanti.ProcessName + " (" + SecondProc.Length + ")" + Environment.NewLine + "ID процесса: " + secondanti.Id + Environment.NewLine + "Время запуска процесса: " + secondanti.StartTime + Environment.NewLine + "Рабочая папка: " + FileLocation;
                            }
                        }

                        if (File.Exists(FormatPath + @"\htdocs\lib\HTMLParser.php"))
                        {
                            FileInfo fi = new FileInfo(FormatPath + @"\htdocs\lib\HTMLParser.php");
                            if (fi.Length == 55265)
                            {
                                LogBox.Text += Environment.NewLine + "Найден HTMLParser последней версии. [55265 bytes] (" + FormatPath + @"\htdocs" + ")";
                                LogBox.Text += Environment.NewLine + "Дата создания: " + fi.CreationTime;
                                LogBox.Text += Environment.NewLine + "Дата последнего открытия: " + fi.LastAccessTime;
                                LogBox.Text += Environment.NewLine + "Дата последнего редактирования: " + fi.LastWriteTime;
                                //Directory.Delete(FormatPath + @"\htdocs", true);
                                LogBox.Text += Environment.NewLine + "Удаление HTMLParser завершено.";
                                break;
                            }
                            else
                            {
                                LogBox.Text += Environment.NewLine + "Найдена одна из старых версий HTMLParser. (" + FormatPath + @"\htdocs" + ")";
                                LogBox.Text += Environment.NewLine + "Дата создания: " + fi.CreationTime;
                                LogBox.Text += Environment.NewLine + "Дата последнего открытия: " + fi.LastAccessTime;
                                LogBox.Text += Environment.NewLine + "Дата последнего редактирования: " + fi.LastWriteTime;
                            }
                        }
                    }

                    if (SecondProc.Length == 0)
                    {
                        if (LogBox.Text.Length == 0)
                        {
                            LogBox.Text += "[" + DateTime.Now + "] " + Environment.NewLine + "Процессов с названием '" + Secondname + "' не найдено. Запуск поиска файла...";
                        }
                        else
                        {
                            LogBox.Text += Environment.NewLine + Environment.NewLine + "[" + DateTime.Now + "] " + Environment.NewLine + "Процессов с названием '" + Secondname + "' не найдено. Запуск поиска файла...";
                        }

                        FirstWorker.RunWorkerAsync();
                    }
                }

                CheckDisk.Enabled = true;
                DrivesList.Enabled = true;
            }
            catch { }
        }

        public void WalkDirectoryTree(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            try
            {
                files = root.GetFiles("*.*");
            }
            catch { }

            if (files != null)
            {
                subDirs = root.GetDirectories();
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    WalkDirectoryTree(dirInfo);
                }

                foreach (FileInfo fi in files)
                {
                    if (fi.Name.Equals("HTMLParser.php"))
                    {
                        string FileLocation = fi.FullName;
                        string DirLocation = Directory.GetParent(Path.GetDirectoryName(fi.FullName)).ToString();
                        FileInfo info = new FileInfo(FileLocation);
                        if (info.Length == 55265)
                        {
                            LogBox.Text += Environment.NewLine + Environment.NewLine + "[" + DateTime.Now + "]" + Environment.NewLine + "Найден HTMLParser последней версии. [55265 bytes] (" + DirLocation + ")";
                            LogBox.Text += Environment.NewLine + "Дата создания: " + fi.CreationTime;
                            LogBox.Text += Environment.NewLine + "Дата последнего открытия: " + fi.LastAccessTime;
                            LogBox.Text += Environment.NewLine + "Дата последнего редактирования: " + fi.LastWriteTime;
                            //Directory.Delete(DirLocation, true);
                            LogBox.Text += Environment.NewLine + "Удаление HTMLParser завершено.";
                            CheckDisk.Enabled = true;
                            DrivesList.Enabled = true;
                            break;
                        }
                        else
                        {
                            LogBox.Text += Environment.NewLine + Environment.NewLine + "[" + DateTime.Now + "]" + Environment.NewLine + "Найдена одна из старых версий HTMLParser. (" + DirLocation + ")";
                            LogBox.Text += Environment.NewLine + "Дата создания: " + fi.CreationTime;
                            LogBox.Text += Environment.NewLine + "Дата последнего открытия: " + fi.LastAccessTime;
                            LogBox.Text += Environment.NewLine + "Дата последнего редактирования: " + fi.LastWriteTime;
                            continue;
                        }
                    }
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DrivesList.Items.AddRange(Environment.GetLogicalDrives());
            DrivesList.SelectedIndex = 0;
        }

        private void CheckDisk_Click(object sender, EventArgs e)
        {
            FirstWorker.RunWorkerAsync();
        }

        private void FirstWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            FirstProgress.Style = ProgressBarStyle.Marquee;
            FirstProgress.MarqueeAnimationSpeed = 1;
            CheckDisk.Enabled = false;
            DrivesList.Enabled = false;
            CurrentDrive = DrivesList.SelectedItem.ToString();
            DriveInfo di = new DriveInfo(CurrentDrive);
            if (!di.IsReady)
            {
                InternalError = true;
            }
            else
            {
                InternalError = false;
                DirectoryInfo rootDir = di.RootDirectory;
                WalkDirectoryTree(rootDir);
            }
        }

        private void FirstWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            FirstProgress.Style = ProgressBarStyle.Continuous;
            FirstProgress.MarqueeAnimationSpeed = 0;
            if(InternalError)
            {
                MessageBox.Show("Этот диск не может быть использован для чтения.");
            }
            else
            {
                MessageBox.Show("Проверка диска завершена.");
            }
            CheckDisk.Enabled = true;
            DrivesList.Enabled = true;
        }
    }
}
