//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Configuration;

//namespace Common.Authentication
//{
//    internal class JWTConfigurationManager
//    {
//        private static string secret { get; set; } = null;
//        private static long lifeTime { get; set; } = 0;

//        /// <summary>
//        /// کلیدی که در این روش تولید کردم در هر اجرای برنامه یک رمز جدید تولید میکند. بنابراین توکنهای هر اجرا مجزا از اجرای قبلی ارزیابی میشوند
//        /// </summary>
//        public static string Secret
//        {
//            get
//            {
//                if (string.IsNullOrEmpty(secret))
//                {
//                    string TempKey = "No more evasion: We have with a leaven'd and prepared choice 60 Proceeded to you; therefore take your honours. Our haste from hence is of so quick condition That it prefers itself and leaves unquestion'd Matters of needful value. We shall write to you, As time and our concernings shall importune, 65 How it goes with us, and do look to know What doth befall you here.So, fare you well; To the hopeful execution do I leave you Of your commissions.";
//                    string Key = null;

//                    try
//                    {
//                        Key = ConfigurationManager.AppSettings["Secret"].ToString();
//                        if (Key.Length < 50)
//                            Key = null;
//                    }
//                    catch
//                    {
//                        Key = null;
//                    }

//                    if (String.IsNullOrEmpty(Key))
//                    {
//                        Key = TempKey;
//                    }

//                    secret = StringCipher.Encrypt(Key, "愛の気分で。 彼女が私を望んでいるなら、私は彼女のために死ぬでしょう。。");
//                }

//                return secret;
//            }
//        }
//        public static long LifeTime
//        {
//            get
//            {
//                if (lifeTime == 0)
//                {
//                    long Value = 0;
//                    long.TryParse(ConfigurationManager.AppSettings["LifeTime"], out Value);
//                    if (Value == 0)
//                        lifeTime = 30;
//                    else if (Value == -1)
//                        lifeTime = long.MaxValue;
//                    else
//                        lifeTime = Value;
//                }
//                return lifeTime;
//            }
//        }
//    }
//}
