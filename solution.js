for (let i=1; i<=100; i++){
    let answer = '';
    if (i % 3 === 0){
        answer += 'Fizz';
    }
    if (i % 5 === 0){
        answer += 'Buzz';
    }
    if ( i % 7 === 0){
        answer += 'Bang';
    }
    if (i % 11 === 0){
        answer = 'Bong';
    }
    // check if empty
    if (!answer) answer = i;
    console.log(answer);
}