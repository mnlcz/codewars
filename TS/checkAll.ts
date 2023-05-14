import {status as kyu8status} from "./8kyu";
//import {status as kyu7status} from "./7kyu";
//import {status as kyu6status} from "./6kyu";

const statuses: Array<boolean> = [];

statuses.push(kyu8status);
//statuses.push(kyu7status);
//statuses.push(kyu6status);

console.log(statuses.every(s => s) ? "PASS" : "FAIL");