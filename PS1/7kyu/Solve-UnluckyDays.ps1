function UnluckyDays([int] $year) {
    [int] $day = 13;
    [int] $counter = 0;
    1..12 | ForEach-Object {
            $name = Get-Date -Day $day -Month $_ -Year $year -Format "dddd"
            if ($name -eq "friday") {
                $counter++
            }
        }
    return $counter
}
