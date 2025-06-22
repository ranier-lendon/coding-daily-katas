local function basic_op(operator, value1, value2)
    if operator == "+" then
        return value1 + value2
    elseif operator == "-" then
        return value1 - value2
    elseif operator == "*" then
        return value1 * value2
    elseif operator == "/" then
        return value1 / value2
    end
    return nil
end

return basic_op