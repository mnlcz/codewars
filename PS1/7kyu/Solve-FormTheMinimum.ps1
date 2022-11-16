function Get-MinValue ([int[]]$values) {
    $out = "" 
    $arr = $values | select -Unique | sort
    $arr.ForEach{ $out += $_ }
    $out
}
