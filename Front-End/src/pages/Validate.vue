<template>
  <div class="container">
    <h1 class="validate">恭喜完成驗證</h1>
    <br />
    <h3 class="validate">接下來將跳轉至首頁，跳轉後請從右上角會員圖示登入</h3>
  </div>
</template>
<script>
import "@/assets/css/index.css";
import { mapGetters } from "vuex";
export default {
  data() {
    return {};
  },
  created() {
    var param = this.$route.query.account;
    if (param == undefined || param == null) {
      this.$router.push("Index");
    } else {
      this.$store.dispatch("VerifyAccount", {
        m_account: param
      });
    }
    setTimeout(function() {
      this.location.replace("Index");
    }, 3000);
  }
};
</script>