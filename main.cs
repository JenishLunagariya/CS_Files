using System;
namespace main{
    class type{
        static void Type(){
            int a = 1;
            float f = 5.45F;
            double d = 1.2678D;
            char c = 'a';
            bool b = true;
            string s = "Hello jenish";
            Console.WriteLine("int:{0}, double:{1}, char:{2}, bool:{3}, string:{4}, float:{5}",a,d,c,b,s,f);
        }
        static void Const(){
            const int x = 14;
            Console.WriteLine("const x: {0}",x);
            // x = 13;
            // Console.WriteLine(x);

        }
        static int Sum(int a,int b){
            return a+b;
        }
        static void Hello(string name){
            Console.WriteLine("Hello, "+name);
        }
        static void ManyVar(int a){
            int x,y,z;
            x=y=z=a;
            Console.WriteLine("x:{0}, y:{1}, z:{2}",x,y,z);
        }
        // Auto-matic type cating: from smaller size to larger size
        // Manual type casting: from larger size to smaller size
        static void IntToDouble(int a){
            double d = a; // automatic type-casting
            Console.WriteLine("Int:{0} to Double:{1}",a,d);
        }
        static void DoubletoInt(double d){
            int i = (int) d;
            Console.WriteLine("Double:{0} to Int:{1}",d,i);
        }
        static void Greet(){
            string name = Console.ReadLine();
            Console.WriteLine("Greetings from {0}",name);
        }
        static void Operations(float a,float b){
            float sum = a + b;
            float substract = a -b;
            float multifly = a*b;
            float divide = a/b;
            Console.WriteLine("sum:{0}, substract:{1}, multifly:{2}, divide:{3}",sum,substract,multifly,divide);
        }
        static void GreaterThan(float a, float b){
            Console.WriteLine("a is greater than b: {0}",(a>b));
        }
        static int len(string str){
            return str.Length;
        }
        static void IfElse(bool userinput){
            if (userinput){
                Console.WriteLine("Userinput was true");
            }else{
                Console.WriteLine("Userinput was false");
            }
        }
        static void SwitchCase(int day){
            string Day;
            switch(day){
                case 1:
                    Day = "Monday";
                    break;
                case 2:
                    Day = "Tuesday";
                    break;
                case 3:
                    Day = "Wednesday";
                    break;
                case 4:
                    Day = "Thursday";
                    break;
                case 5:
                    Day = "Friday";
                    break; 
                default:
                    Day = "Weekends";
                    break;
            }
            Console.WriteLine("Today is {0}",Day);
        }
        static void ForLoop(int n){
            for (int i=0;i<n;i++){
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("");
        }
        static void WhileLoop(int n){
            int i=0;
            while (i<n){
                Console.Write(i);
                Console.Write(" ");
                i++;
            }
            Console.WriteLine("");
        }
        static void DoWhileLoop(int n){
            int i = 0;
            do{
                Console.Write(i);
                Console.Write(" ");
                i++;
            }while(i<n);
            Console.WriteLine("");
        }
        static void ForEachLoop(){
            string[] cars = {"Volvo","Audi","BMW","Skoda","Renualt","Suzuki","Mahindra","Tata","Honda","Hyundai","Jeep","Benz","Viper","Tesla"};
            foreach (string car in cars){
                Console.Write("{0} | ",car);
            }
            Console.WriteLine("");
        }
        static void print(int num){
            Console.WriteLine(num);
        }
        static void print(string str){
            Console.WriteLine(str);
        }
        static void Main(){
            Type();
            Const();
            Hello("Jenish");
            Console.WriteLine("sum: "+Sum(9,8));
            ManyVar(20);
            IntToDouble(8);
            DoubletoInt(7.89);
            // Greet();
            Operations(2.67F,9.78F);
            Console.WriteLine(3 ^ 6);
            GreaterThan(14.67F,8.67F);
            Console.WriteLine(
                "Max:{0}, Min:{1}",
                Math.Max(2,3),
                Math.Min(2,3)
            );
            Console.WriteLine(len("Hello Jenish"));
            IfElse(false);
            bool userinput = true;
            string result = (userinput) ? "Userinput was True":"Userinput was False";
            Console.WriteLine(result);
            SwitchCase(6);
            ForLoop(5);
            WhileLoop(5);
            DoWhileLoop(5);
            ForEachLoop();
            print(5);
            print("Jenish");
            
            
        }
        
    }
    
}