function evaporator([double]$content, [double]$evapperday, [double]$threshold) {
    $days = 0
    $perc = 100
    while ($perc -gt $threshold) {
        $perc -= $perc * $evapperday / 100
        $days++
    }
    $days
}
