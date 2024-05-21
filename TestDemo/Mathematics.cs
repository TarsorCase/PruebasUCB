namespace TestDemo;  

public static class Mathematics {  

public static bool IsEvenNumber(int num) {  

return num % 2 == 0 ? true : false;  

}  

public static bool IsOddNumber(int num) {  

return num % 2 == 1 ? true : false;  

}  

public static int SquareOfNumber(int num) {  

int sum = 0;  

for (int count = 1; count <= num; count++) {  

sum = count * count;  

}  

return sum;  

}  

public static double Addition(double num1, double num2) { return (num1 + num2);  

}  

public static double Subtraction(double num1, double num2) { return (num1 - num2);  

}  

public static double Multiplication(double num1, double num2) { 

return (num1 * num2);  

}  

public static double Division(double num1, double num2) {  

return (num1 / num2);  

}  
public static int AreaLote(int num1, int num2) { return (num1 * num2);
}  

public static int VolumenCubo(int num1, int num2, int num3) { return (num1 * num2 * num3);
}

public static int ConvMetroCL(int num1) { return (num1 * 1000);
}

public static int ConvMetroLC(int num1) { return (num1 / 1000);
}  

public static int ConvMetro(int num1) { return (num1 / 1000);
}

public static int (int num1) { return (num1 / 1000);
}  
}
