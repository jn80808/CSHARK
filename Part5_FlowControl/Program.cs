// See https://aka.ms/new-console-template for more information


//if - else 
#region -- if else -- 
// Console.WriteLine("");
// Console.WriteLine("***************");
// Console.WriteLine("-- if elase ! --");

// const int MAX_MINOR_AGE = 17;
// const int MIN_SENIOR_AGE = 60;
// var isAverageAge = true;
// var ages = 25 ;
// Console.WriteLine("Input your Age: ");
// var ageString = Console.ReadLine();
// var age = int.Parse(ageString);
// if (age <= MAX_MINOR_AGE || age >= MIN_SENIOR_AGE)
// {
//     Console.WriteLine ("Add minor and senior discount");
// } 
// else if (isAverageAge)
// {
//     Console.WriteLine ("No discount Your Age is out of Scope for discount");
// }
// else 
// {
//     Console.WriteLine("no Discount");
// }


// //Client Requirements : No 5 discount for ADULT.
// //Implementation #1
// if (age > MAX_MINOR_AGE && age <MIN_SENIOR_AGE)
// {
// }
// else
// {
//     Console.WriteLine("Implementation #1 Added 5 discount");
// }

// //implementation #2 
// if (!(age > MAX_MINOR_AGE && age <MIN_SENIOR_AGE))
// {
//     Console.WriteLine("implementation #2 added 5 discount");
// }

#endregion

//Switch 
#region -- SWITCH -- 

// Console.WriteLine("");
// Console.WriteLine("***************");
// Console.WriteLine("-- Switch ! --");

// Console.WriteLine("Input your Age: ");
// var ageString = Console.ReadLine();
// var age = int.Parse(ageString);

// switch (age)
// {
//     case 1:
//         Console.WriteLine("baby");
//         break;
//      case 10:
//      case 11:
//      case 12:
//      case 13:
//      case 14:
//      case 15:
//      case 16:
//             Console.WriteLine("teen");
//             break ;
//         default:
//             Console.WriteLine("unknown");
//             break;
// }

#endregion



//While

#region -- while --

Console.WriteLine();
    Console.WriteLine("****************");
    Console.WriteLine("While");
    var count = 0;

    while (count < 3)
    {
        count++;
        Console.WriteLine(count);
    }
    #endregion

    // Do While 
    #region  -- do while -- 
    Console.WriteLine();
    Console.WriteLine("****************");
    Console.WriteLine("do While");
    do 
    {
        Console.WriteLine("Print using do while");
        Console.WriteLine(count);
        count++;
    } while (count < 3);
    
    #endregion

    //for loops 
    #region -- for loops -- 
    Console.WriteLine();
    Console.WriteLine("****************");
    Console.WriteLine("for loops");

    Console.WriteLine("");
    Console.WriteLine("++1");
    //index++ equivalent to index = index + 1 or index +=1;
    for (var index = 0 ; index <= 5 ; index ++ )
    {
        Console.WriteLine($"index value {index}");
    }
    Console.WriteLine("");
    Console.WriteLine("+=2");
    for (var index = 0 ; index <= 5 ; index += 2 )
    {
        Console.WriteLine($"index value {index}");
    }

    #endregion

    //foreach 
    #region -- foreach -- 
    Console.WriteLine();
    Console.WriteLine("****************");
    Console.WriteLine("foreach ");

    var nameSegments = new [] {"pro", "grammer", "tv"};
    foreach (var segment in nameSegments)
    {
        Console.WriteLine ($"segment value: {segment}");
    }

void PrintName()
{
    throw new NotImplementedException();
}

void Process()
{
    throw new NotImplementedException();
}
#endregion

