function Get-SumOfPositive($NumberArray) {
    return $NumberArray | Where { $_ -gt 0 } | Measure-Object -Sum | % Sum
}
