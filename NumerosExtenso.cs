using System;

namespace NumerosPorExtenso
{
    class NumerosExtenso
    {
        static void Main(string[] args)
        {
            string[] unidades = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            string[] unidadeEspecial = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] decimais = { "", "dez",  "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] centenas = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };
            string[] milhares = { "", "mil", "dois mil", "três mil", "quatro mil", "cinco mil", "seis mil", "sete mil", "oito mil", "nove mil", };

            string numeroExtenso = "";
            int indiceMilhar;
            int indiceCentena;
            int indiceDezena;
            int indiceUnidade;
            int indiceUnidadeEspecial;

            Console.Write("Digite um número entre 0 e 9999:");
            string numero = Console.ReadLine();
            while (numero[0] == '0')
            {
                if (numero == "0")
                {
                    numeroExtenso = "Zero";
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um número sem 0 á esquerda: ");
                    numero = Console.ReadLine();
                }
            }

            switch (numero.Length)
            {
                case 4:
                    indiceMilhar = int.Parse(numero[0].ToString());
                    numeroExtenso =  milhares[indiceMilhar];
                    indiceCentena = int.Parse(numero[1].ToString());
                    numeroExtenso += centenas[indiceCentena];
                    if (numero[2] == '1' && numero[3] != '0')
                    {
                        indiceUnidadeEspecial = int.Parse(numero[2].ToString());
                        numeroExtenso += unidadeEspecial[indiceUnidadeEspecial];
                    }
                    else
                    {
                        indiceDezena = int.Parse(numero[2].ToString());
                        numeroExtenso += decimais[indiceDezena];
                        indiceUnidade = int.Parse(numero[3].ToString());
                        numeroExtenso += unidades[indiceUnidade];
                    }
                    break;
                case 3:
                    indiceCentena = int.Parse(numero[0].ToString());
                    numeroExtenso += centenas[indiceCentena];
                    if (numero[1] == '1' && numero[2] != '0')
                    {
                        indiceUnidadeEspecial = int.Parse(numero[2].ToString());
                        numeroExtenso += unidadeEspecial[indiceUnidadeEspecial];
                    }
                    else
                    {
                        indiceDezena = int.Parse(numero[1].ToString());
                        numeroExtenso += decimais[indiceDezena];
                        indiceUnidade = int.Parse(numero[2].ToString());
                        numeroExtenso += unidades[indiceUnidade];
                    }
                    if (numero[0] == '1' && numero[1] == '0' && numero[2] == '0')
                    {
                        numeroExtenso = "cem";
                    }
                    break;
                case 2:
                    if (numero[0] == '1' && numero[1] != '0')
                    {
                        indiceUnidadeEspecial = int.Parse(numero[1].ToString());
                        numeroExtenso += unidadeEspecial[indiceUnidadeEspecial];
                    }
                    else
                    {
                        indiceDezena = int.Parse(numero[0].ToString());
                        numeroExtenso += decimais[indiceDezena];
                        indiceUnidade = int.Parse(numero[1].ToString());
                        numeroExtenso += unidades[indiceUnidade];
                    }
                    break;
                case 1:
                    indiceUnidade = int.Parse(numero[0].ToString());
                    numeroExtenso += unidades[indiceUnidade];
                    break;
                default:
                    break;
            }
            Console.Write(numeroExtenso);
            Console.ReadLine();
        }
    }
}
