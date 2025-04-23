# H1 Logic của bài
1. **Tạo một method để tính tổng các chữ số (digit sum) của một số nguyên**
2. **Tạo một Dictionary**:
   - `Key`: tổng chữ số (digitSum)
   - `Value`: đếm số lượng số có cùng tổng đó
3. **Duyệt tất cả số từ `1 → n`**
   - Với mỗi số:
     - Gọi `DigitSum(i)` để tính tổng chữ số
     - Nếu key đã có trong dictionary → tăng `value` lên 1
     - Nếu chưa có → thêm key mới với value = 1
4. **Tìm `maxCount` = giá trị cao nhất trong `dictionary.Values`**
5. **Trả lại số lượng key có value = maxCount**


- cách tính tổng giá trị các digit của từng số:
```
 public int DigitSum(int n) {
        int sum = 0;        // tạo biến mới sum để lưu giá trị
        while (n > 0) {     // Lặp khi số còn > 0
            sum += n % 10;  // Lấy chữ số cuối cùng (vd: 123 → 3)
            n /= 10;         // Bỏ chữ số cuối đi (123 → 12)
        }
        return sum;         // Trả tổng chữ số
    }
```
- ``` Values()``` dùng với Dictionary là viết tất cả các value trong dictionary (bỏ qua key) vào một collection kiểu kiểu array í
- ```Max()``` thì là để tìm ra giá trị lớn nhất
