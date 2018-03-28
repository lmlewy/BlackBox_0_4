using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;

namespace SPA5BlackBoxReader
{
    class ListOfFrames
    {
        public ListOfFrames()
        {

        }

        public List<string[]> DecodeFileAsList( byte[] binFile)
        {
            List<string[]> DecodedFrameList = new List<string[]>();

            //// to działa ale mogło by byc szybsze
            //for (int i = binFile.Length - (1+5); i > 0; i--)
            //{
            //    if ((binFile[i] == 0xff) && (binFile[i + 1] == 0xff) && (binFile[i + 2] == 0xff) && (binFile[i + 3] == 0xff) && (binFile[i + 4] != 0xff))
            //    {
            //        int frameLenght = (binFile[i + 4] << 8) + binFile[i + 5];
            //        byte[] b = new byte[frameLenght];
            //        for (int j = 0; j < frameLenght; j++)
            //        {
            //            b[j] = binFile[i + 4 + j];
            //        }
            //        DataFrame df = new DataFrame(cultureInfo);
            //        List<string[]> tempList = df.DecodeDataFrameToList(b);

            //        foreach (string[] s in tempList)
            //            DecodedFrameList.Add(s);
            //    }
            //}
            //// to działa ale mogło by byc szybsze

            //może jest szybsze ale tu coś jest nie tak bo nie odczytuje wszystkich ramek!!!
            //int i = binFile.Length - (1+5);
            //do
            //{
            //    if ((binFile[i] == 0xff) && (binFile[i + 1] == 0xff) && (binFile[i + 2] == 0xff) && (binFile[i + 3] == 0xff) && (binFile[i + 4] != 0xff))
            //    {
            //        int frameLenght = (binFile[i + 4] << 8) + binFile[i + 5];
            //        byte[] b = new byte[frameLenght];
            //        for (int j = 0; j < frameLenght; j++)
            //        {
            //            b[j] = binFile[i + 4 + j];
            //        }
            //        DataFrame df = new DataFrame();
            //        List<string[]> tempList = df.DecodeDataFrameToList(b);

            //        foreach (string[] s in tempList)
            //            DecodedFrameList.Add(s);

            //        i -= frameLenght;
            //    }
            //    i--;
            //} while (i > 0);


            //kolejny sposob
            int i = 4;
            do
            {
                if ((binFile[i] != 0xff) && (binFile[i - 1] == 0xff) && (binFile[i - 2] == 0xff) && (binFile[i - 3] == 0xff) && (binFile[i - 4] == 0xff))
                {
                    int frameLenght = (binFile[i] << 8) + binFile[i + 1];
                    byte[] b = new byte[frameLenght];
                    for (int j = 0; j < frameLenght; j++)
                    {
                        b[j] = binFile[i + j];
                    }
                    DataFrame df = new DataFrame();
                    List<string[]> tempList = df.DecodeDataFrameToList(b);

                    foreach (string[] s in tempList)
                        DecodedFrameList.Add(s);

                    i += (frameLenght - 1);
                }
                else
                {
                    i++;
                }


            } while (i < binFile.Length);





             return DecodedFrameList;
        }

    }
}
