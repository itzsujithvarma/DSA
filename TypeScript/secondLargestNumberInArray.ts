function findSecondLargestNumberInArray(arr:number[]) {
let largestNumber: number = arr[0];
let secondLargestNumber: number = Number.NEGATIVE_INFINITY;

for(let i = 1; i < arr.length; i++) {
    if(arr[i] > largestNumber) {
        secondLargestNumber = largestNumber;
        largestNumber = arr[i];
    } else if(arr[i] > secondLargestNumber && arr[i] < largestNumber) {
        secondLargestNumber = arr[i];
    }
}
console.log(`Second largest number is ${secondLargestNumber}`)
}

findSecondLargestNumberInArray([34,54,78,12,1]);