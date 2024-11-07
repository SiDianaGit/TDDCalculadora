using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using AppCalculadora;


namespace CalculadoraTest
{
    public class AppCalculadoraTest
    {
        public Calcular construirClasse()
        {
            Calcular calc = new Calcular();
            return calc;
        }


        [Theory]
        [InlineData (1,2,3)]
        [InlineData (2,3,5)]
        public void Sum_TwoIntegerNumbers_Success(int val1, int val2, int result) //WhenGivenThen
        {
            //Arrange
            Calcular calc = construirClasse();
            
            //Act
            int resultCalc = calc.Somar(val1, val2);

            //Assert
            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData (10,2,8)]
        [InlineData (5,3,2)]
        public void Subtract_TwoIntegerNumbers_Success(int val1, int val2, int result) //WhenGivenThen
        {
            //Arrange
            Calcular calc = construirClasse();
            
            //Act
            int resultCalc = calc.Subtrair(val1, val2);

            //Assert
            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData (1,2,2)]
        [InlineData (2,3,6)]
        public void Mult_TwoIntegerNumbers_Success(int val1, int val2, int result) //WhenGivenThen
        {
            //Arrange
            Calcular calc = construirClasse();
            
            //Act
            int resultCalc = calc.Multiplicar(val1, val2);

            //Assert
            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData (4,2,2)]
        [InlineData (9,3,3)]
        public void dividir_TwoIntegerNumbers_Success(int val1, int val2, int result) //WhenGivenThen
        {
            //Arrange
            Calcular calc = construirClasse();
            
            //Act
            int resultCalc = calc.Dividir(val1, val2);

            //Assert
            Assert.Equal(result, resultCalc);
        }

        [Fact]
        public void dividir_ByZero_Error() //WhenGivenThen
        {
            //Arrange
            Calcular calc = construirClasse();
            
            //Act
            //Assert
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(1,0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            //Arrange
            Calcular calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 3);
            calc.Somar(3, 4);
            calc.Somar(4, 5);
            calc.Somar(5, 6);

            //Act
            var lista = calc.Listar();

            //Assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);


        }


    }
}