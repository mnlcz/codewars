import {testEven} from "./isEven";
import {between} from "./whatIsBetween";
import {powersOfTwo} from "./powersOf2";
import {findAverage} from "./calculateAverage"

const tests: Array<boolean> = [];
const compareArr = <T>(a1: Array<T>, a2: Array<T>) => a1.every((value, index) => value === a2[index]);

tests.push(testEven(2));
tests.push(!testEven(3));
tests.push(compareArr(between(1, 4), [1, 2, 3, 4]));
tests.push(compareArr(powersOfTwo(0), [1]));
tests.push(compareArr(powersOfTwo(1), [1, 2]));
tests.push(compareArr(powersOfTwo(2), [1, 2, 4]));
tests.push(findAverage([2,2,2,2]) === 2);
tests.push(findAverage([]) === 0);

export const status = tests.every(t => t);