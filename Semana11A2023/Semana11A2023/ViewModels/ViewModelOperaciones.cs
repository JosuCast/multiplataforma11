using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Semana11A2023.ViewModels
{
    public class ViewModelOperaciones : ViewModelBase
    {

        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }


        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }



        int resultadoSuma;
        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoResta;
        public int ResultadoResta
        {
            get { return resultadoResta; }
            set
            {
                if (resultadoResta != value)
                {
                    resultadoResta = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoMultiplicacion;
        public int ResultadoMultiplicacion
        {
            get { return resultadoMultiplicacion; }
            set
            {
                if (resultadoMultiplicacion != value)
                {
                    resultadoMultiplicacion = value;
                    OnPropertyChanged();
                }
            }
        }

        double resultadoDivision;
        public double ResultadoDivision
        {
            get { return resultadoDivision; }
            set
            {
                if (resultadoDivision != value)
                {
                    resultadoDivision = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }

        public ViewModelOperaciones()
        {
            Sumar = new Command(() =>
            {
                ResultadoSuma = ValorA + ValorB;
            });

            Restar = new Command(() =>
            {
                ResultadoResta = ValorA - ValorB;
            });

            Multiplicar = new Command(() =>
            {
                ResultadoMultiplicacion = ValorA * ValorB;
            });

            Dividir     = new Command(() =>
            {
                ResultadoDivision = ValorA / ValorB;
            });
        }

    }
}
