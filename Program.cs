//N. Harrison Wilkins
//10-18-2022
//GitHub Project Part 5
//This project will tell a pre mae story and ask the user for specific inputs to create a random story using a prompt.
//PEER REVIEW IS IN README

Console.Clear();

//all variables regarding the game should be declared here
string verbOne, celebrityOne, carNameOne, adjOne, movieOne, locationOne, foodOne, petName, sportsTeam, carNameTwo;

Console.WriteLine("HEY! GOOD TO SEE YOU! ENTER \"Y\" TO START OUR GAME, OR ENTER ANY KEY TO EXIT.");
do{
    Console.WriteLine("THAT'S GREAT NEWS! LETS GET STARTED! FIRST, I NEED A VERB.");
    verbOne = Console.ReadLine().ToUpper();

    Console.WriteLine("OK, NOW I NEED A CELEBRITY NAME!");
    celebrityOne = Console.ReadLine().ToUpper();
    
    Console.WriteLine("GEEZ, ARE YOU STILL A FAN AFTER ALL THE TIMES THEY GOT CANCELLED? ANYWAYS, I NEED TO KNOW THE NAME OF A CAR COMPANY!");
    carNameOne = Console.ReadLine().ToUpper();

    Console.WriteLine("I'M MORE OF A FERRARI GUY, BUT "+carNameOne+" WORKS TOO! NEXT IS AN ADJECTIVE!");
    adjOne = Console.ReadLine().ToUpper();

    Console.WriteLine("NOW TIME FOR A FAMOUS MOVIE THAT YOU KNOW!");
    movieOne = Console.ReadLine().ToUpper();

    Console.WriteLine("I HAVEN'T SEEN THAT ONE YET! WHAT ABOUT A FAMOUS HISTORICAL LOCATION?");
    locationOne = Console.ReadLine().ToUpper();

    Console.WriteLine("OK, NOW LET'S HEAR A DELICIOUS FOOD!");
    foodOne = Console.ReadLine().ToUpper();

    Console.WriteLine("OK, NOW A NAME FOR A PET.");
    petName = Console.ReadLine().ToUpper();

    Console.WriteLine("THAT'S CUTE!! NOW TIME FOR YOUR FAVORITE BASKETBALL TEAM OR COLLEGE.");
    sportsTeam = Console.ReadLine().ToUpper();

    Console.WriteLine("PICK SOMEONE GOOD LIKE THE PACKERS NEXT TIME! I JUST NEED ANOTHER CAR COMPANY!");
    carNameTwo = Console.ReadLine().ToUpper();
        Console.WriteLine("THANKS SO MUCH! I HOPE YOU HAD AS MUCH FUN AS I DID! ENTER \"Y\" TO CONTINUE.");

    while(Console.ReadLine().ToUpper() != "Y"){
        Console.WriteLine("ENTER \"Y\" TO CONTINUE....");
    }
//writelines below are split in orer to keep words from cutting in half in the terminal when the story is output.
Console.WriteLine("ACCORDING TO YOUR ANSWERS, OUR STORY GOES LIKE THIS...");
Console.WriteLine("");

Console.WriteLine("THE TIME CAME FOR THE PEOPLE TO " +verbOne+ " BEHIND THE GREAT LEADER " +celebrityOne+ ". THE PRESIDENTIAL " +carNameOne);
Console.WriteLine("CAME SCREECHING AROUND THE CORNER LIKE A " +adjOne+ " BAT! THE PRESIDENT COULD NOT BE LATE FOR THE FINAL SHOWING OF " +movieOne+ ".");
Console.WriteLine("EVERYONE KNOWS IT'S THEIR FAVORITE MOVIE, AND NO ONE WOULD STOP THEM FROM GETTING TO " +locationOne+ " WHERE IT WOULD BE SHOWN FOR THE FINAL TIME!");
Console.WriteLine("INSIDE THERE POCKET, THEY HELD THEIR " +foodOne+ " FIRMLY, HOPING NO ONE WOULLD NOTICE GOING INTO THE THEATRE! ALL OF A SUDDEN, A VICIOUS DOGGY BY THE NAME OF " +petName);
Console.WriteLine("JUMPED OUT AFTER SMElLING THE DELICIOUS " +foodOne+ " IN THE PRESIDENT'S POCKET. THINKING THEY WERE BIGGER THAN THE LAW, " +celebrityOne+ " TRIED TO RUN, BUT WAS TACKLED");
Console.WriteLine("BY THE STARTING CENTER FOR (THE) " +sportsTeam+ ". THEY WERE CONGRATULATED AND " +celebrityOne+ " WAS HAULED OFF TO JAIL IN THE POICE ISSUED " +carNameTwo+ ".");

Console.WriteLine("");
Console.WriteLine("ENTER \"Y\" TO PLAY AGAIN, OR ENTER ANY KEY TO EXIT");

}while(Console.ReadLine().ToUpper() == "Y");