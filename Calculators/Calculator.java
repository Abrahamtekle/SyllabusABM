public class Calculator {

    static int sum(int a, int b) {
        return a + b;
    }

    static int subtraction(int a, int b) {
        return a - b;
    }

    public static void main(String[] args) {
        int num1 = 10;
        int num2 = 4;

        System.out.println("=== ABM Calculator (Java) ===");
        System.out.println("Number 1: " + num1);
        System.out.println("Number 2: " + num2);
        System.out.println("Sum:         " + num1 + " + " + num2 + " = " + sum(num1, num2));
        System.out.println("Subtraction: " + num1 + " - " + num2 + " = " + subtraction(num1, num2));
    }
}
