
// document.getElementById("myName").innerHTML = "Nevin Seibel";
// console.log("27");
// alert("Wisconsin");

// let hoursWorked = prompt("Please enter hours worked");
// let payRate = prompt("Please enter pay rate");
// let totalPay;

// totalPay = hoursWorked * payRate;

// document.getElementById("myName").innerHTML = totalPay;


// let hoursWorked = prompt("Please enter hour work");
// let payRate = prompt("Please enter pay rate");
// let overTimeStart = 50;
// let overTimeMultiplier = 1.5
// let totalPay;


// if(hoursWorked > overTimeStart){
//     let overTimePayRate = payRate * overTimeMultiplier;
//     let overTimeHours = hoursWorked - overTimeStart;
//     let totalOverTimePay = overTimeHours * overTimePayRate;
//     let regPay = overTimeStart * payRate;
//     totalPay = totalOverTimePay + regPay;
// }
// else{
//     totalPay = hoursWorked * payRate;
// }


//console.log(totalPay);


for(let i = 1; i < 101; i++){

    //i%15 == 0 ? console.log("FizzBuzz"): i%5 ==0 ? console.log("Fizz"): i%3 == 0? console.log("Buzz"): console.log(i);
    
    if(i%5==0 && i%3 == 0){
        console.log("FizzBuzz")
    }
    else if(i%5 == 0){
        console.log("Fizz");
    }
    else if(i%3 == 0){
        console.log("Buzz")
    }
    else{
    console.log(i);
    }
}


function printString(str){
    if(str.length <= 3){
        console.log("We need a bigger string")
    }else{
        
    }
}