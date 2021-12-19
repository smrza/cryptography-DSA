using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace DSA
{
    public class RSA
    {
        public BigInteger n { get; set; }
        public BigInteger e { get; set; }
        public BigInteger d { get; set; }
        BigInteger p;
        BigInteger q;
        BigInteger eulerFunction;

        public RSA(int bitLength)
        {
            ValueTuple<BigInteger, BigInteger> tuple = SetRandomPrimes(bitLength);
            p = tuple.Item1;
            q = tuple.Item2;
            n = p * q;
            eulerFunction = (p - 1) * (q - 1);
            e = SetE(bitLength);
            d = extendedGCD(e, eulerFunction);
        }

        public RSA(BigInteger n, BigInteger d, BigInteger e)
        {
            this.e = e;
            this.n = n;
            this.d = d;
        }

        public RSA(BigInteger e, BigInteger n)
        {
            this.n = n;
            this.e = e;
        }

        public RSA()
        {
            //empty constructor to reset
        }

        public string Sign(string data)
        {
            return Convert.ToString(BigInteger.ModPow(ReturnMessageNumber(data), d, n));
        }

        public bool Verify(string data, string signature)
        {
            if (ReturnMessageFromNumber(BigInteger.ModPow(BigInteger.Parse(signature), e, n)) == data)
            {
                return true;
            }
            else return false;
        }

        private ValueTuple<BigInteger, BigInteger> SetRandomPrimes(int bitLength)
        {
            BigInteger p;
            BigInteger q;

            do
            {
                do
                {
                    //p = p - 1;
                    p = GenerateRandomBigInteger(bitLength);
                    if (p < 0)
                    {
                        p *= -1;
                    }
                } while (IsPrime(p, 4) != true);

                do
                {
                    //q = q - 1;
                    q = GenerateRandomBigInteger(bitLength);
                    if (q < 0)
                    {
                        q *= -1;
                    }
                } while (IsPrime(q, 4) != true);

            } while (p == q);

            return (p, q);
        }


        private BigInteger GenerateRandomBigInteger(int lenght)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[lenght / 8];
            rng.GetBytes(bytes);
            return new BigInteger(bytes);
        }

        private bool IsPrime(BigInteger number, int certainty)
        {
            if (number == 2 || number == 3)
            {
                return true;
            }
            if (number < 2 || number % 2 == 0)
            {
                return false;
            }

            BigInteger d = number - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[number.ToByteArray().LongLength];
            BigInteger a;

            for (int i = 0; i < certainty; i++)
            {
                do
                {
                    rng.GetBytes(bytes);
                    a = new BigInteger(bytes);
                }
                while (a < 2 || a >= number - 2);

                BigInteger x = BigInteger.ModPow(a, d, number);
                if (x == 1 || x == number - 1)
                {
                    continue;
                }

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, number);
                    if (x == 1) return false;
                    if (x == number - 1) break;
                }

                if (x != number - 1) return false;
            }

            return true;
        }

        private BigInteger SetE(int bitLength)
        {
            BigInteger e;

            do
            {
                e = GenerateRandomBigInteger(bitLength);
                if (e < 0)
                {
                    e *= -1;
                }
            } while (e >= eulerFunction || BigInteger.GreatestCommonDivisor(e, eulerFunction) != 1);

            return e;
        }
        /*
        private BigInteger GCD(BigInteger p, BigInteger q)
        {
            BigInteger r = 1;

            if (p > q)
            {
                BigInteger tmp = p;
                p = q;
                q = tmp;
            }

            while (r != 0)
            {
                r = q % p;

                if (r == 0)
                {
                    break;
                }

                q = p;
                p = r;
            }

            return p;
        }
        */

        private BigInteger extendedGCD(BigInteger a, BigInteger n)
        {
            BigInteger i = n;
            BigInteger v = 0;
            BigInteger d = 1;

            while (a > 0)
            {
                BigInteger t = i / a;
                BigInteger x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0)
            {
                v = (v + n) % n;
            }
            return v;
        }

        private BigInteger ReturnMessageNumber(string input)
        {
            byte[] partOfMessage = Encoding.ASCII.GetBytes(input);
            return new BigInteger(partOfMessage);
        }

        private string ReturnMessageFromNumber(BigInteger byteArrayNumber)
        {
            byte[] decryptedByteArray = byteArrayNumber.ToByteArray();
            string decryptedText = "";
            for (int i = 0; i < decryptedByteArray.Length; i++)
            {
                decryptedText += Convert.ToString(Convert.ToChar(decryptedByteArray[i]));
            }

            return decryptedText;
        }
    }
}
