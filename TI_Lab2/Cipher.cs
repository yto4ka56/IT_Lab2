using System.Collections;

namespace TI_Lab2;

public class Cipher
{
    public BitArray BitReg { get; private set; }
    public BitArray BitKey { get; private set; }
    public BitArray PlainText { get; set; }
    public BitArray CipherText { get; private set; }

    public void GetRegBit(string reg)
    {
        BitReg = new BitArray(reg.Length);
        for (int i = 0; i < reg.Length; i++)
        {
            BitReg[i] = reg[i] == '1';
        }
    }

    public void GetBitKey(int length)
    {
        BitKey = new BitArray(length);
        for (int i = 0; i < length; i++)
        {
            BitKey[i] = BitReg[0];
            
            bool nextValue = BitReg[35] ^ BitReg[10];

            for (int index = 0; index < BitReg.Length - 1; index++)
            {
                BitReg[index] = BitReg[index + 1];
            }

            BitReg[35] = nextValue;
        }
    }

    public void GetCipher()
    {
        CipherText = BitKey.Xor(PlainText);
    }
}