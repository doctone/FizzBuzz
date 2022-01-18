function isDivisibleBy(a, b){
    return a%b === 0;
}

for (let i=1; i<=255; i++){
    let answer = [];
    if (isDivisibleBy(i, 3)){
        answer.push('Fizz');
    }
    if (isDivisibleBy(i, 5)){
        answer.push('Buzz');
    }
    if (isDivisibleBy(i, 7)){
        answer.push('Bang');
    }
    if (isDivisibleBy(i, 11)){
        answer = ['Bong'];
    }
    if (isDivisibleBy(i, 13)){
        /// TO DO
    }

    if (isDivisibleBy(i, 17)){
        answer.reverse();
    }

    // check if empty
    if (!answer.length) {
        answer = [i.toString()];
    }
    console.log(answer.join(''));
}