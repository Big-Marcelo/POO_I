// 1 - diferença entre tipos primitivos (ou tipos de valor) e tipos de referência.

  //A diferença entre tipos de dados primitivos e referência é que os tipos primitivos sãos passados por valor e os tipos de referência sãos passados por referência. também é possível passar um tipo de referência como parâmetro de uma função.
  //exemplos de códigos de tipos primitivos e tipos de referência:
  //int a = 10;
  //int b = a;

//2 - como corrigir o erro no código abaixo:

  object obj = "123";
  int x = (int)obj;
  //Convert.ToInt32()

//3 - Qual é a saída deste código?
  
  string numStr = "99";
  int num = int.Parse(numStr);
  Console.WriteLine(num);
  //99