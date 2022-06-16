namespace CalculatorUsingEnum
{
    enum EOperator
    {
        // enum 값은 정수형이 들어갈 수 있는데 char를 enum 값으로 대입할 수 있는 이유
        // char도 정수형이기 때문. ASCII
        Plus = '+',
        Minus = '-',
        Multiply = '*',
        Divide = '/',
        Mod = '%'
    }
}