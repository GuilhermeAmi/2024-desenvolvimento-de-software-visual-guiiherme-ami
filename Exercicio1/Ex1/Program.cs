
// See https://aka.ms/new-console-template for more information
int[] resposta = BubbleSort();



// int AreaQuadrado(int a, int b){
//    return a *b;
// }

// RetornoConversor ConversorDeMoeda(double real){
//    return new RetornoConversor(real);
// }

// int ComparadorDeNumeros(int numero1, int numero2){
//    int resposta = numero1 > numero2 ? numero1 : numero2;
//    return resposta;
// }

// String LerIdade(int idade){
//    if(idade <13 ){
//       return "criança";
//    } else if(idade <= 18){
//       return "adolescente";
//    } else if(idade <= 60) {
//       return "adulto";
//    } else
//    {
//       return "idoso";
//    }
// }

// int[] ImprimirFibonacci(int limite){
   
// }

// int[] BubbleSort(){
//    Random randNum = new Random();
//    int tamanho = 1000;
//    int[] valores = new int [tamanho];

//    for(int i = 0; i < tamanho; i++){
//       valores[i] = randNum.Next(tamanho);
//    }
   

//    for(int i = 1; i < tamanho; i++){
//       if(valores[i] < valores[i - 1]){
//          for(int j = i; j > 0; j--){
//             if(valores[j] < valores[j-1]){
//                int temp = valores[j - 1];
//                valores[j-1] = valores[j];
//                valores[j] = temp;
//             } else {
//                break;
//             }
//          }
//       }
//    }

//    for(int i = 0; i < tamanho; i++){
//       Console.Write(valores[i] + " ");
//    }

//    return valores;
// }

// public class RetornoConversor{
//    double Dolar;
//    double Euro;
//    double PesoArgentino;

//    public RetornoConversor(double real){
//       this.Dolar = real * 5.17;
//       this.Euro = real * 6.14;
//       this.PesoArgentino= real * 0.05;
//    }
// }

int[] BubbleSort(){
   Random randNum = new Random();
   int tamanho = 1000;
   int[] valores = new int [tamanho];

   for(int i = 0; i < tamanho; i++){
      valores[i] = randNum.Next(tamanho);
   }
   
   bool organizado = false;
   while(!organizado)
   {
      organizado = true;
      for(int i = 1; i < tamanho; i++){
         if(valores[i] < valores[i - 1]){
            organizado = false;
            int temp = valores[i - 1];
            valores[i-1] = valores[i];
            valores[i] = temp;
         }
      }
   }

   for(int i = 0; i < tamanho; i++){
      Console.Write(valores[i] + " ");
   }

   return valores;
}