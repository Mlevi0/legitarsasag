<template>
  <nav class="navbar navbar-expand-lg bg-light">
  <div class="container-fluid">
    <a class="navbar-brand" href="#"><img src="/icon.png" alt="logo" style="max-height:40px;"></a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav">
        <li class="nav-item">
        <RouterLink to="/" class="nav-link">Utazások</RouterLink>
        </li>
        <li class="nav-item">
        <RouterLink to="/foglalas" class="nav-link">Foglalás</RouterLink>
        </li>
        <li class="nav-item">
        <RouterLink to="/aboutus" class="nav-link">Rólunk</RouterLink>
        </li>
      </ul>
    </div>
  </div>
</nav>
</template>
<script>
</script>