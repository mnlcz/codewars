function strongNumber ([int]$number) {
    $str = $number.ToString()
    $n = $str.Length
    $sum = 0
    $str.ToCharArray().ForEach{
        $x = [int]$_
        $sum += Factorial $x
    }
    $sum -eq $number ? "STRONG!!!!" : "Not Strong !!"
}

function Factorial($n) {
    $n -ge 1 ? $n * (Factorial ($n - 1)) : 1
}

