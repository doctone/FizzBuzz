/*
If a number is a multiple of 13, print "Fezz" instead of the number. 
For multiples of most other numbers, the Fezz goes immediately in front of the first thing beginning with B, 
or at the end if there are none. (E.g. 5 * 13 = 65: "FezzBuzz", 3 * 5 * 13 = 195: "FizzFezzBuzz"). 
Note that Fezz should be printed even if Bong is also present (E.g. 11 * 13 = 143: "FezzBong")
*/

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
    if (i % 13 === 0){
        // find 'B'
        let index = answer.indexOf('B');
        // if there's no 'B' word, put 'Fezz' on the end
        if (index < 0){
            answer += 'Fezz';
        }
        // otherwise, insert 'Fezz' before the 'B' word
        else {
            answer = answer.slice(0, index) + 'Fezz' + answer.slice(index);
        }
    }
    // check if empty
    if (!answer) answer = i;
    console.log(answer);
}