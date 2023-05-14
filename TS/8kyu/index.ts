import {testEven} from "./isEven";
import {between} from "./whatIsBetween";

const tests: Array<boolean> = [];

tests.push(testEven(2));
tests.push(!testEven(3));
tests.push(between(1, 4).every((value, index) => value === [1, 2, 3, 4][index]));

export const status = tests.every(t => t);