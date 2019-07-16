


function printString(food){
    if(food.length <= 3){
        console.log("we need a longer string");
    }
    else{
        console.log(food)
    }
}

let something = prompt("Please enter a word");
printString(something);
printString(something);