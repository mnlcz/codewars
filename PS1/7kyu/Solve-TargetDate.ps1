function date-nb-days($a0, $a, $p) {
    $date = Get-Date -Day 1 -Month 1 -Year 2016
    while ($a0 -lt $a) {
        $a0 = $a0 + ($a0 * $p / 100 / 360)
        $date = $date.AddDays(1)
    }
    $date | Get-Date -Format "yyyy-MM-dd"
}

