export function powersOfTwo(n: number): number[] {
    let i = 0;
    let arr: Array<number> = [];
    while (i <= n) {
        arr.push(2 ** i);
        i++;
    }
    return arr;
}