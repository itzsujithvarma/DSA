function reverseArrayWithoutAnotherArray(arr: number[]) {
    let temp: number;
    for(let i = 0,j = arr.length -1; i<j; i++,j--) {
        temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    console.log(arr.join(","))
}
reverseArrayWithoutAnotherArray([34,54,78,12,1]);