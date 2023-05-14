export function findAverage(array: number[]): number {
    return array.length === 0 ? 0 : array.reduce((sum, current) => sum + current, 0) / array.length;
}