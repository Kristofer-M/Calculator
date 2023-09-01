# Калкулатор
Project by: Кристофер Младеновски

# Опис на апликација
Апликацијата е класичен Калкулатор со основни функционалности и експоненти, квадратен корен, процент и меморија. Апликацијата се користи со кликање на покажувачот на копчиња на апликацијата.

### Меморија
Со притискање на M+ или M- додека немате број во меморија, ќе го додадете прикажаниот број во меморија, а со MC се брише дадениот број од меморија.
### Процент
Процентот работи како во класичните калкулатори т.е. ви го дава процентот од претходниот број, и го евалуира математичкиот израз, на пример `100 + 20%` прво ќе израчуна колку е 20% од 100, и тоа ќе го додаде на 100ката, значи крајниот резултат ќе биде `120`.

# Опис на решението
Целиот код се наоѓа во класата `Calculator` која што наследува од `Form`. 

### Атрибути
1. `public String input` - Атрибут кој содржи стринг од математичкиот израз што се покажува на TextBox-от на Калкулаторот.
2. `public String expression` - Атрибут кој содржи како изгледа математичкиот израз што всушност ќе се реши со помош на `matheval` библиотеката.
3. `public Dictionary<String, String> operators` - Атрибут кој содржи речник за преведување на "input" оператори во "expression" оператори кои што се разбирливи на `Expression.Eval()` методот.
4. `public String memory` - Атрибут кој ја содрши вредноста зачувана во меморијата.

## Функциите кои го евалуираат математичкиот израз
### `updateInput(String text)`
```c#
private void updateInput(String text)
{
    if (operators.ContainsKey(text))
    {
        expression += operators[text];
    }
    else
    {
        expression += text;
    }
    input += text;

    tbInput.Text = input;
}
```
Оваа функција проверува дали корисникот притиснал некој оператор што треба да се преведе, го преведува операторот, и го сменува текстот во `tbInput`.

Пример: Корисникот притиснува `√`
```c#
private void buttonSqrt_Click(object sender, EventArgs e)
{
    updateInput("√(");
}
```
се поставува `√(` во `tbInput`, но во `expression` се поставува `sqrt(`
```c#
public Dictionary<String, String> operators = new Dictionary<string, string>()
{
    {"×", "*" },
    {"÷", "/" },
    {"√(", "sqrt(" },
    {"%", "/100" }
};
```
бидејќи тој израз е разбирлив за функцијата `Expression.Eval()`.
### `buttonEquals_Click(object sender, EventArgs e)`
```c#
private void buttonEquals_Click(object sender, EventArgs e)
{
    string output = "";

    try
    {
        if (!string.IsNullOrEmpty(expression))
        {
            var mathExpression = new Expression(expression);
            double number;
            output = mathExpression.Eval().ToString();

            if (double.TryParse(output, out number))
            {
                if (number % 1 == 0)
                {
                    int wholeNumber = (int)number;
                    output = wholeNumber.ToString();
                }
            }
        }
    }
    catch (Exception)
    {
        output = "ERROR";
    }
    finally
    {
        updateOutput(output);
    }
}
```
Оваа функција проверува дали изразот е празен, го евалуира конвертираниот израз со `mathExpression.Eval()`, и проверува дали резултатот е цел double, и ако е, го претвата во int.
Ако екпресијата не е точно поставена, ако има незатворена заграда, или ако има оператор без број итн. се фаќа тој error и се прикажува ERROR на `tbInput` display-от.

# Изглед на апликацијата
![Screenshot од апликацијата](https://github.com/Kristofer-M/Calculator/blob/master/Calculator.png)
