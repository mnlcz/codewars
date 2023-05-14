export function between(a: number, b: number): number[] {
    let arr: Array<number> = [];
    for (a; a !== b + 1; a++) arr.push(a);
    return arr;
}