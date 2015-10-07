
function Get-SummeLokal
{
    param(
       [parameter(Mandatory=$true)][int]$num1, 
       [parameter(Mandatory=$true, ValueFromPipeline=$true)] [int]$num2)

    Write-Verbose "`$num1 value: $num1"
    Write-Verbose "`$num2 value: $num2"
    $num1 + $num2
}




