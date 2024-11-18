using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace RSA_для_конфы
{
    public partial class Form1 : Form
    {
        //сколькими битами кодируется один символ, используется представление в UTF-16
        const int charSize = 16;

        // основные два числа из которых генерируются ключи
        int firstNumber;
        int secondNumber;

        //функция Эйлера
        int eulerFunction;

        //nNumber - общая первая часть для закрытого и открытого ключа 
        //publicExp - публичная экспонента, вторая часть открытого ключа
        //dNumber -  вторая часть закрытого ключа
        int nNumber;
        int publicExp;
        int dNumber;

        //генератор чисел
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        //кнопка создает систему RSA
        private void generateRSASys_button_Click(object sender, EventArgs e)
        {
            //генерируем числа и выводим их
            firstNumber = CreatePrime();
            secondNumber = CreatePrime();
            firstNumberText.Text = firstNumber.ToString();
            secondNumberText.Text = secondNumber.ToString();

            //счиатем nNumber, общую первую часть закрытого и открытого ключа
            nNumber = firstNumber * secondNumber;

            //счиатем функцию эйлера
            eulerFunction = CalсEulerFunction(firstNumber, secondNumber);

            //создаем публичную экспоненту, вторую часть открытого ключа
            publicExp = 3557;

            //создаем dNumber, вторую часть закрытого ключа
            
            dNumber = CreatePrivateExp(eulerFunction, publicExp);
            if(dNumber < 0)
            {
                dNumber = -dNumber;
            }

            //выводим открытый и закрытый ключ
            publicKey.Text = nNumber.ToString() + '\t' + publicExp.ToString();
            privateKey.Text = nNumber.ToString() + '\t' + dNumber.ToString();
        }

        //кнопка шифрует введенное сообщение
        private void encrypt_button_Click(object sender, EventArgs e)
        {
            //берем значение сообщения
            string message = messageText.Text;

            //объявляем массив кодов для каждого из символов сообщения
            int[] codes = new int[message.Length];

            //объявляем массив зашифрованных кодов для каждого из символов сообщения
            int[] encryptedCodes = new int[message.Length];

            //объявляем строку зашифрованного сообщения
            string encryptedStr;

            //переводим каждый символ в коды
            for (int i = 0; i < message.Length; i++)
            {
                codes[i] = Convert.ToInt32(CharToBinaryFormat(message[i]), 2);
            }

            //шифруем каждый из кодов символов, умножение на 5 неообходимо для исключения использования системных кодов юникода
            for (int i = 0; i < message.Length; i++)
            {
                encryptedCodes[i] = Encrypt(codes[i], publicExp, nNumber) * 3;
            }

            //очищаем строку
            messageText.Text = "";

            //выводим зашифрованную абракадабру
            for (int i = 0; i < message.Length; i++)
            {
                encryptedStr = Convert.ToString(encryptedCodes[i], 2);
                messageText.Text = messageText.Text + StringFromBinaryToNormalFormat(encryptedStr);
            }

        }

        //кнопка дешифрует введенное сообщение
        private void decrypt_button_Click(object sender, EventArgs e)
        {
            //берем значение сообщения
            string message = messageText.Text;

            //объявляем массив кодов для каждого из символов сообщения
            int[] codes = new int[message.Length];

            //объявляем массив расшифрованных кодов для каждого из символов сообщения
            int[] dencryptedCodes = new int[message.Length];

            //объявляем расшифрованную строку 
            string decryptedStr;

            //переводим каждый символ в коды
            for (int i = 0; i < message.Length; i++)
            {
                codes[i] = Convert.ToInt32(CharToBinaryFormat(message[i]), 2);
            }

            //расшифровываем каждый из кодов символов, деление на 5 неообходимо для исключения использования системных кодов
            for (int i = 0; i < message.Length; i++)
            {
                codes[i] = codes[i] / 3;
                dencryptedCodes[i] = Decrypt(codes[i], dNumber, nNumber);
            }

            //очищаем строку
            messageText.Text = "";

            //выводим расшифрованное  сообщение
            for (int i = 0; i < message.Length; i++)
            {
                decryptedStr = Convert.ToString(dencryptedCodes[i], 2);
                messageText.Text = messageText.Text + StringFromBinaryToNormalFormat(decryptedStr);
            }
        }

        int Gcd(int a, int b, out int x, out int y)
        {
            if (b < a)
            {
                var t = a;
                a = b;
                b = t;
            }

            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            int gcd = Gcd(b % a, a, out x, out y);

            int newY = x;
            int newX = y - (b / a) * x;

            x = newX;
            y = newY;
            return gcd;
        }

        //метод возвращает истину если число простое, ложь в противном случае
        private bool IsPrime(int primeNumber)
        {
            bool result = true;

            for (int i = 2; i <= primeNumber / 2; i++)
            {
                if (primeNumber % i == 0)
                {
                    return result = false;
                }
            }
            return result;
        }

        //метод генерирует простое число
        private int CreatePrime()
        {
            int primeNumber = rnd.Next(32, 128);

            //перегенирируем до тех пор, пока число не будет простым
            while (!IsPrime(primeNumber))
            {
                primeNumber = rnd.Next(32, 128);
            }

            return primeNumber;
        }

        //метод вычисляет значение функции эйлера
        private int CalсEulerFunction(int firstNumber, int secondNumber)
        {
            return (firstNumber - 1) * (secondNumber - 1);
        }

        //метод генерирует публичную экспоненту, т.е. вторую часть открытого ключа
        private int CreatePrivateExp(int f, int publicExp)
        {
            int a = publicExp;
            int b = f, x = 0, d_ = 1;
            while (a > 0)
            {
                int q_ = b / a;
                int y = a;
                a = b % a;
                b = y;
                y = d_;
                d_ = x - q_ * d_;
                x = y;
            }
            x = (x + f) % f;
            return x;
        }

        private int CreatePublicExp(int f)
        {
            int d = f - 1;

            for (int i = 2; i <= f; i++)
            {
                if ((f % i == 0) && (d % i == 0))
                {
                    d--;
                    i = 1;
                }
            }
  
            return d;
        }

        private int Encrypt(int inputNumber, int publicExp, int nNumber)
        {
            BigInteger number = new BigInteger(inputNumber);
            return (int)(BigInteger.Pow(number, publicExp) % nNumber);
        }

        private int Decrypt(int inputNumber, int dNumber, int nNumber)
        {
            BigInteger number = new BigInteger(inputNumber);
            return (int)(BigInteger.Pow(number, dNumber) % nNumber);
        }


        private string CharToBinaryFormat(char ch)
        {
            string out_str = "";

            string char_binary = Convert.ToString(ch, 2);

            while (char_binary.Length < charSize)
                char_binary = "0" + char_binary;

            out_str += char_binary;

            return out_str;
        }

        private string StringFromBinaryToNormalFormat(string str)
        {
            string output = "";

            int resultNumber = 0;
            int degree = str.Length - 1;

            foreach (char ch in str)
                resultNumber += Convert.ToInt32(ch.ToString()) * (int)Math.Pow(2, degree--);

            output = ((char)resultNumber).ToString();

            return output;
        }
    }
}
