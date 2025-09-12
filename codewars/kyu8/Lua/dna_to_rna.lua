local function dna_to_rna(dna)
  return dna:gsub("T", "U")
end

return dna_to_rna