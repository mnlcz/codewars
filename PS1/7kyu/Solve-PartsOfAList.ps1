function part-list([string[]] $arr)
{
    $solutionsNumber = $arr.Length - 1
    $out = ""
    foreach ($i in 1..$solutionsNumber) 
    {
        $out += "("
        for ($j = 0; $j -lt $arr.Length; $j++)
        {
            if ($j -eq $i - 1)
            {
                $out += $arr[$j] + ", " 
            }
            elseif ($j -eq $solutionsNumber)
            {
                $out += $arr[$j] + ")"
            }
            else
            {
                $out += $arr[$j] + " "    
            }
        }
    }
    return $out
}
