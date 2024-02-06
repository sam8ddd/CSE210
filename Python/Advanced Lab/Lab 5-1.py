from statsmodels.stats.proportion import proportions_ztest

out = proportions_ztest(count=63, nobs=100, value=0.7)
print(out)