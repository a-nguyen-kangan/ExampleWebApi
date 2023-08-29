var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//-----------------------------------
app.MapGet("/", () => "Hello A38!");
app.MapGet("/name/generic", () => functionCall());

//functions
string functionCall() {
    return anotherFunction();
    return "Called functionCall";
}

string anotherFunction() {
    return "Another function got called";
}
//---------------------------------
app.MapGet("/addNums/{num1}/{num2}", (int num1, int num2) => (num1 + num2));

app.MapGet("/addNumsFunc/{num1}/{num2}", (int num1, int num2) => addNumsFunc(num1, num2));

int addNumsFunc(int num1, int num2) {
    return num1 + num2;
}



//
//larsen
app.MapGet("/Larsen", () => "Hello Larsen");

//yooki 
app.MapGet("/Yuki",() => "Hello egg!");
//nada
app.MapGet("/Nada", () => "Hello Nada!");
//darren

app.MapGet("/darren", () => "hi"); 

//faz
app.MapGet("/faz", () => "Hello Faz");

//rahma
app.MapGet("/rahma", () => "Hello Rahma");  

//dylan

//will
app.MapGet("/will", () => "Hello Will");





app.Run();
