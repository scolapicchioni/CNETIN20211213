// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using FirstConsoleApplication;

List<Employee> employees = new List<Employee>() {
    new Employee(1, "Aaa", "Aaaa"),
    new Employee(2, "Baa", "Aaaa"),
    new Employee(3, "Caa", "Aaaa"),
    new Employee(4, "Daa", "Aaaa"),
    new Employee(5, "Eaa", "Aaaa"),
    new Employee(20, "Faa", "Aaaa"),
    new Employee(100, "Gaa", "Aaaa"),
};

var uiList = employees.Select(e => new { e.Id, e.Name, Status = e.Id switch { 1 => "Founder", 2 => "Co founder", _ => "Just an employee" } });

foreach (var item in uiList) {
    Console.WriteLine(item);
}

void IfExpressionDemo() {

    string SwitchExpressionBody(int x) => x switch {
            10 => "x is 10",
            15 => "x is 15",
            20 => "x is 20",
            _ => "x is big"
        };

    string SwitchExpression(int x) {
        string result = x switch {
            10 => "x is 10",
            15 => "x is 15",
            20 => "x is 20",
            _ => "x is big"
        };
        return result;
    }

    string Switch(int x) {
        string result;
        switch (x) {
            case 10:
                result = "x is 10";
                break;
            case 15:
                result = "x is 15";
                break ;
            case 20:
                result = "x is 20";
                break;
            default:
                result = "x is big";
                break;
        }
        return result;
    }

    string IfExpression(int x) => (x > 10) ? "x is big" : "x is small";

    string If(int x) {
        string result;
        if (x > 10) {
            result = "x is big";
        } else {
            result = "x is small";
        }
        return result;
    }
}

void RecordsExample() { 
    Employee employee1 = new Employee(1, "Employee 1","Surname 1");
    Employee employee2 = new Employee(1, "Employee 1", "Surname 1");

    Console.WriteLine(employee1 == employee2);
    Console.WriteLine(employee1);
    Employee employee3 = employee1 with { Surname = "Other Surname" };
    Console.WriteLine(employee3);

    (int i, string n, string s) = employee3;
    Console.WriteLine(i);
    Console.WriteLine(n);
    Console.WriteLine(s);
    employee3.DoSomething();
}

void IndexerExample() {
    
    Bank bank = new Bank();
    BankAccount b1 = bank.OpenAccount("Simona", 1);
    BankAccount b2 =  bank.OpenAccount("Mario",2);
    b2.WithDraw(100);

    //BankAccount b3 = new BankAccount();
}


void DeconstructExample() {
    var tuple1 = (1,"hi", true);

    //deconstruct
    (int a, string b, bool c) = tuple1;

    DeconstructDemo o1 = new() {IntProperty = 10, BoolProperty = true, StringProperty = "OH HI!!" };

    (a, b, c) = o1;

}


void DestructorExample() {
    for (int i = 0; i < 1_000_000; i++) {
        ConstructorsDemo c1 = new ConstructorsDemo() { IntProperty = 1};
    }
    
}

void ConstructorExample() {
    ConstructorsDemo c1 = new ConstructorsDemo();
    ConstructorsDemo c2 = new (10,false, new Customer { Name="Simona"}, "Ciao!");

    Console.WriteLine(c1);
}






void LabStuff() { 
    int[,] grid = new int[3,3];
    bool[] alreadyGeneratedNumbers = new bool[3 * 3];
    

    Random generator = new Random();

    for (int r = 0; r < grid.GetLength(0); r++) {
        for (int c = 0; c < grid.GetLength(1); c++) {
            int number;
            int index;
            bool IAlreadyHadThisNumberBefore;
            do {
                number = generator.Next(1, 10);
                index = number - 1;
                IAlreadyHadThisNumberBefore = alreadyGeneratedNumbers[index];
            } while (IAlreadyHadThisNumberBefore);

            grid[r, c] = number;
        }
    }
}

void Arrays01() {
    int[] myTable;
    int[][] myTableOfTables;
    int[,,] myTwoDimTable;

    myTable = new int[3];
    myTableOfTables = new int[5][];
    myTwoDimTable = new int[5, 3,4];

    myTableOfTables[0] = new int[3];
    myTableOfTables[1] = new int[2];
    myTableOfTables[2] = new int[5];
    myTableOfTables[3] = new int[4];
    myTableOfTables[4] = new int[6];

    myTable = new int[3] { 5, 15, 10};
    int[] myTable2 = { 5, 15, 10 };


    int[] a1 = new int[4] { 5, 15, 10, 22 };
    int[] a2 = { 5, 15, 10, 22 };

    int[] a3;
    a3 = new int[4] { 5, 15, 10, 22 };

    //int[] a4;
    //a4 = { 5, 15, 10, 22 };
    int[] a5 = new int[4]; //0,0,0,0

    for (int i = 0; i < a1.Length; i++) {
        a1[i] = i * 5;
    }

    for (int i = 0; i < a1.Length; i++) {
        Console.WriteLine(a1[i]);
    }

    int[,] grid = new int[5, 3];
    for (int r = 0; r < grid.GetLength(0); r++) {
        for (int c = 0; c < grid.GetLength(1); c++) {
            grid[r, c] = (r + 1) * (c + 1);
        }
    }
    for (int r = 0; r < grid.GetLength(0); r++) {
        for (int c = 0; c < grid.GetLength(1); c++) {
            Console.Write($"{grid[r, c]}\t"); 
        }
        Console.WriteLine();
    }
}

void TuplesExample() {
    //Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1,"aa",true);

    //(int, string, bool) tuple = (1, "aa", true);

    (int TheInt, string TheString, bool TheBool) tuple = (1, "aa", true);

    int i;
    string s;
    bool b;

    (i, s, b) = tuple;

    (i, s, b) = (1, "aa", true);

    int n1 = 5;
    int n2 = 10;

    (n1, n2) = (n2, n1);

    (int i2, string s2, bool b2) = tuple;

    (int A, string B) theResult = MethodWithTuple();


    (int i1, string s1) = MethodWithTuple();



    (int TheInt, string TheString) MethodWithTuple() {
        return (5, "hi");
    }

}
void NamedArguments() {
    MyMethod(2, "ss", true, 2.3);

    Settings(
        acceptCookies: true,
        anotherThing: true,
        securityEnabled: false
        );

    MyLongListOfParameters(anotherThing: false);
}

void MyLongListOfParameters(bool acceptCookies = true, bool securityEnabled = false, bool anotherThing = true) { 

}

void Settings(bool acceptCookies, bool securityEnabled, bool anotherThing) { 

}


void MyMethod(int a, string b, bool c, double d) { 

}

Add("1",2,3,4,5);

int Add(string x, params int[] numbers) {
    int result = 0;
    foreach (var item in numbers) {
        result += item;
    }
    return result;
}

void InOutRefExample() {
    int x;
    bool ok = int.TryParse("123", out x);
    if (ok == true) {
        Console.WriteLine(x);
    }


    int argument = 5;
    //Console.WriteLine($"argument is now {argument}");
    Increment(ref argument);
    Console.WriteLine($"argument is now {argument}");

    void Increment(ref int parameter) {
        Console.WriteLine($"parameter is now {parameter}");
        parameter++;
        Console.WriteLine($"parameter is now {parameter}");
    }

}
void Method04_Exceptions() {
    Console.WriteLine("Method 4 is starting...");
    BusinessLogic();
    Console.WriteLine("everything went well...");
}


void BusinessLogicFinally() {
    Customer c = new Customer();
    c.Name = "Simona";
    try {
        SaveCustomer(c);
        Console.WriteLine("the customer has been saved");
        
    } catch { 

    } 
    finally {

    }
    Console.WriteLine("BusinessLogic is done and happy because everything is allright");
}

void BusinessLogicWhen() {
    Customer c = new Customer();
    c.Name = "Simona";
    try {
        SaveCustomer(c);
        Console.WriteLine("the customer has been saved");
    } catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound){
        Console.WriteLine("we're handling some other problem here");
    } catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.ExpectationFailed) {
        Console.WriteLine("we're handling some other problem here");
    } catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.BadRequest) {
        Console.WriteLine("we're handling some other problem here");
    }
    Console.WriteLine("BusinessLogic is done and happy because everything is allright");
}


void BusinessLogicSimple() {
    Customer c = new Customer();
    c.Name = "Simona";
    try {
        SaveCustomer(c);
        Console.WriteLine("the customer has been saved");
    } catch{
        Console.WriteLine("we're handling some other problem here");
    }
    Console.WriteLine("BusinessLogic is done and happy because everything is allright");
}

void BusinessLogic() {
    Customer c = new Customer();
    c.Name = "Simona";
    try {
        SaveCustomer(c);

        Console.WriteLine("the customer has been saved");
    } catch (FileNotFoundException ex) {
        Console.WriteLine($"we're handling the File Not Found Exception here: {ex.Message}");
    } catch (ArgumentNullException) {
        Console.WriteLine("we're handling the ArgumentNullException here");
    } catch (IndexOutOfRangeException) {
        Console.WriteLine("we're handling the IndexOutOfRangeException here");
    } catch (NameTooLongException ex) { 
        
    } catch (Exception) {
        Console.WriteLine("we're handling some other problem here");
    }
    Console.WriteLine("BusinessLogic is done and happy because everything is allright");
}

void SaveCustomer(Customer c) {
    //file open
    throw new FileNotFoundException("Oh no, file abc.txt is not there!");
    //serialize customer
    throw new ArgumentNullException();
    //close file
    throw new IndexOutOfRangeException();
    //done
    throw new Exception("the message");
    throw new NameTooLongException("oh noes!") { MaxAllowedLength = 255, FoundLenght = 1000};
}

void BusinessLogicOtherLanguages() {
    Customer c = new Customer();
    c.Name = "Simona";
    int result_code = SaveCustomerOtherLanguages(c);
    if (result_code == -2655) {
        Console.WriteLine("Sorry, we had a problem with the file!");

    } else if (result_code == -567823923) {

    }
    Console.WriteLine("the customer has been saved");
}
int SaveCustomerOtherLanguages(Customer c) {
    //file open
    return -2655;
    //serialize customer
    return -567823923;
    //close file
    return -4678394;
    //done
    return 0;
}

void Method03_ForEach() {
    string[] listOfStrings = { "first word", "second word", "third word" };
    foreach (string element in listOfStrings) {
        Console.WriteLine(element);
    }

    Customer[] customers = new Customer[] {
        new Customer(){ Name = "Simona", Surname = "Colapicchioni"},
        new Customer(){ Name = "Mario", Surname = "Super"},
        new Customer(){ Name = "Luigi", Surname = "Super"}
    };
    foreach (Customer element in customers) {
        Console.WriteLine(element);
    }

    //List<Customer> list = new List<Customer>();
    //HashSet<Customer> list = new HashSet<Customer>();

    string s = "some stuff";
    foreach (char item in s) {
        Console.WriteLine(item);
    }
}

void Method02_BlockScope() {
    int i = 5;
    if (i > 5) 
    {
        int x = 10;
        //int i = 10;
        Console.WriteLine(i);
    }
    //int x = 10;
    //Console.WriteLine(x);
}




void Method01_structures(){
    Customer c1 = new Customer() { Name = "Customer 1" };

    MyStructure s1 = new MyStructure() { IntProperty = 1, StringProperty = "s1", CustomerProperty = c1 };

    MyStructure s2 = s1;

    Console.WriteLine("Before changing");
    Console.WriteLine(s1);
    Console.WriteLine(s2);
    s2.IntProperty = 2;
    s2.StringProperty = "s2";
    s2.CustomerProperty.Name = "Customer 2";
    Console.WriteLine("***********After changing***********");
    Console.WriteLine(s1);
    Console.WriteLine(s2);
}


