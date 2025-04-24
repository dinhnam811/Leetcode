
# 🧠 Notes học tập – Bài `CountLargestGroup (LeetCode)`

## 🎯 Mục tiêu bài toán:
- Cho số nguyên `n`
- Với mỗi số từ `1 → n`, tính tổng chữ số
- Gom các số theo **tổng chữ số**
- Tìm nhóm có nhiều phần tử nhất, và đếm xem **có bao nhiêu nhóm như vậy**

---

## 🔧 Kỹ năng và kiến thức cần nhớ:

### ✅ 1. **Tính tổng các chữ số của một số**
- Dùng `% 10` để lấy chữ số cuối
- Dùng `/= 10` để bỏ chữ số cuối

```csharp
int DigitSum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}
```

---

### ✅ 2. **Dictionary là gì và khi nào tạo key**

```csharp
Dictionary<int, int> dict = new();

// Tạo key mới:
dict[key] = value;

// Tránh lỗi: kiểm tra key trước khi truy cập
if (!dict.ContainsKey(key))
    dict[key] = 0;
```

- `ContainsKey(k)` → kiểm tra nếu `k` đã tồn tại chưa
- `dict[k]++` chỉ hợp lệ nếu `k` đã tồn tại
- `Dictionary<int, int>` dùng để **đếm**
- `Dictionary<int, List<int>>` dùng để **lưu chi tiết nhóm**

---

### ✅ 3. **Lặp từ 1 đến n**

```csharp
for (int i = 1; i <= n; i++) { ... }
```

- Gọi `DigitSum(i)`
- Cập nhật vào dictionary theo nhóm `digitSum`

---

### ✅ 4. **Tìm số lớn nhất trong dictionary**

```csharp
int maxSize = groupSizes.Values.Max();
```

- `.Values`: lấy danh sách value trong dictionary
- `.Max()`: tìm giá trị lớn nhất

---

### ✅ 5. **Đếm xem có bao nhiêu nhóm đạt size lớn nhất**

```csharp
int count = groupSizes.Values.Count(v => v == maxSize);
```

- Dùng biểu thức `v => v == maxSize` để lọc
- `.Count(...)`: đếm bao nhiêu phần tử thỏa điều kiện

---

## 🧠 Kỹ năng tư duy quan trọng:

| Kỹ năng | Giải thích |
|--------|-------------|
| Tư duy nhóm theo key | Gom theo tổng chữ số (`digitSum`) |
| Kiểm soát Dictionary | Luôn kiểm tra trước khi `.Add()` hoặc `++` |
| Tối ưu bộ nhớ | Không cần lưu `List<int>` nếu chỉ cần đếm |
| Biến phân tích bài toán thành code rõ ràng | Mỗi dòng ứng với 1 hành động logic |

---

## 🔁 Gợi ý luyện tập thêm:

- Viết lại bằng cách **không dùng LINQ** (dùng `foreach`)
- Thử thay `Dictionary` bằng `int[]` nếu biết tổng chữ số max là nhỏ
- Ghi chú nhóm cụ thể bằng `Dictionary<int, List<int>>` để in ra từng nhóm

---

## ✅ Công thức nhớ nhanh:

```csharp
for (int i = 1; i <= n; i++)
{
    int sum = DigitSum(i);
    if (!dict.ContainsKey(sum))
        dict[sum] = 0;
    dict[sum]++;
}

int max = dict.Values.Max();
return dict.Values.Count(v => v == max);
```
